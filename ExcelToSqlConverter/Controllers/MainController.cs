using ExcelToSqlConverter.Models;
using ExcelToSqlConverter.Models.Files;
using ExcelToSqlConverter.Extensions;
using ExcelToSqlConverter.Models.Export;
using ExcelToSqlConverter.Models.Fields;

namespace ExcelToSqlConverter.Controllers
{
    public class MainController : IFieldsToFileHandler, IDisposable
    {
        public List<IFieldOptions> Fields { get; private set; }

        public IFileAdapter Adapter { get; private set; }

        private readonly GuidField guidField = new("Guid");

        private readonly IExporter exporter;

        public MainController()
        {
            Adapter = new NullAdapter();
            Fields = new();
            exporter = new ValuesExporter(this);
        }

        public void ImportCsv(string filename, char splitter, bool headersLine)
            => SetAdapterAndImport(new CsvFileAdapter(filename, splitter, headersLine));

        public void ImportExcel(string filename, string listName, bool headersLine)
            => SetAdapterAndImport(new OpenOffiseExcelFileAdapter(filename, headersLine, listName));

        public void ImportExcelDefault(string filename, bool headersLine)
            => SetAdapterAndImport(new OpenOffiseExcelFileAdapter(filename, headersLine));

        private void SetAdapterAndImport(IFileAdapter adapter)
        {
            Adapter = adapter;
            ImportFile();
        }

        private void ImportFile()
        {
            Fields.Clear();

            var (headers, data) = Adapter.ResetAndReadHeadersAndData();
            if (data is null) return;

            for (int i = 0; i < data.Length; i++)
            {
                var header = headers is null ? $"Header{i}" : headers[i];
                Fields.Add(new FieldOptions(header, i));
            }
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
            => exporter.GetExample();

        public void ExportFile(string to)
        {
            using var sw = new StreamWriter(to);
            exporter.Export(sw);
        }

        public void Dispose()
        {
            Adapter.Dispose();
        }
    }
}
