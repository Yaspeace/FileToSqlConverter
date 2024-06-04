using ExcelToSqlConverter.Models;
using ExcelToSqlConverter.Models.Files;
using ExcelToSqlConverter.Extensions;

namespace ExcelToSqlConverter.Controllers
{
    public class MainController : IDisposable
    {
        public List<IFieldOptions> Fields { get; set; } = new();

        private string[] Headers => Fields?.Select(x => x.Header).ToArray() ?? Array.Empty<string>();

        private readonly GuidField guidField = new("Guid");

        private string[]? cachedData;

        private IFileAdapter? adapter;

        private bool headersLine;

        public void ImportCsv(string filename, char splitter, bool headersLine)
            => SetAdapterAndImport(new CsvFileAdapter(filename, splitter), headersLine);

        public void ImportExcel(string filename, string listName, bool headersLine)
            => SetAdapterAndImport(new OpenOffiseExcelFileAdapter(filename, listName), headersLine);

        public void ImportExcelDefault(string filename, bool headersLine)
            => SetAdapterAndImport(new OpenOffiseExcelFileAdapter(filename), headersLine);

        private void SetAdapterAndImport(IFileAdapter adapter, bool headersLine)
        {
            this.adapter = adapter;
            ImportFile(headersLine);
        }

        private void ImportFile(bool headersLine)
        {
            if (adapter is null) throw new ArgumentNullException(nameof(adapter));

            Fields.Clear();
            this.headersLine = headersLine;

            var data = adapter.Read() ?? Array.Empty<string>();
            for (int i = 0; i < data.Length; i++)
            {
                var header = headersLine ? data[i] : $"Header{i}";
                Fields.Add(new FieldOptions(header, i));
            }

            cachedData = headersLine ? adapter.Read() : data;
        }

        public void AddUnion(string header, string splitter)
            => Fields.Add(new Union(header, splitter));

        public void ReplaceFieldTo(IFieldOptions field, IFieldOptions target)
        {
            if (
                field.Type != OptionsTypeEnum.Field ||
                target.Type != OptionsTypeEnum.Union)
            {
                return;
            }

            target.Fields.Add(field);
            Fields.Remove(field);
        }

        public void Remove(IFieldOptions fieldOpts)
        {
            if (fieldOpts.Type == OptionsTypeEnum.Union)
                Fields.AddRange(fieldOpts.Fields);

            Fields.Remove(fieldOpts);
        }

        public void Move(IFieldOptions field, bool up)
        {
            if (up)
                Fields.MoveForward(field);
            else
                Fields.MoveBackward(field);
        }

        public void SetFieldProperties(object field, string header, bool quotes)
        {
            if (field is not IFieldOptions) return;
            var f = field as IFieldOptions;
            f.Header = header;
            f.Quotes = quotes;
        }

        public void SetUnionProperties(object union, string header, bool quotes, string splitter)
        {
            if (union is not Union) return;
            var u = union as Union;
            u.Header = header;
            u.Quotes = quotes;
            u.Separator = splitter;
        }

        public void SetGuidField(bool enable)
        {
            if (enable)
            {
                if (!Fields.Contains(guidField))
                    Fields.Add(guidField);
            }
            else
            {
                Fields.Remove(guidField);
            }
        }

        public string GetExampleString()
        {
            if (cachedData == null) return "";

            var res = RecordFromData(cachedData);
            var headersStr = string.Join(',', Headers);
            return $"{res} as source({headersStr})";
        }

        private string RecordFromData(string[] data)
        {
            var fieldValuesArr = Fields.Select(x => x.GetFieldValue(data)).ToArray();
            var fieldValues = string.Join(',', fieldValuesArr);

            return $"({fieldValues})";
        }

        public void ExportFile(string to)
        {
            if (adapter == null) throw new ArgumentNullException(nameof(adapter));
            adapter.Reset();

            using var sw = new StreamWriter(to);

            var data = adapter.Read();
            if (headersLine) data = adapter.Read();

            if (data is null) return;

            sw.Write($"(values\n\t{RecordFromData(data)}");

            while (!adapter.End)
            {
                data = adapter.Read();
                if (data == null) break;

                sw.Write($",\n\t{RecordFromData(data)}");
            }

            var headers = string.Join(',', Headers);
            sw.Write($"\n) as source({headers})");
        }

        public void Dispose()
        {
            adapter?.Dispose();
        }
    }
}
