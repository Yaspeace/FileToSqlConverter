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

        private readonly IExporter exporter;

        private int _unionCounter = 1;

        public MainController()
        {
            Adapter = new NullAdapter();
            Fields = new();
            exporter = new ValuesExporter(this);
        }

        public bool ImportCsv(string filename, char splitter, bool headersLine)
        {
            try
            {
                return ImportFile(new CsvFileAdapter(filename, splitter, headersLine));
            }
            catch
            {
                return false;
            }
        }

        public bool ImportExcel(string filename, string listName, bool headersLine)
        {
            try
            {
                return ImportFile(new OpenOffiseExcelFileAdapter(filename, headersLine, listName));
            }
            catch
            {
                return false;
            }
        }

        public bool ImportExcelDefault(string filename, bool headersLine)
        {
            try
            {
                return ImportFile(new OpenOffiseExcelFileAdapter(filename, headersLine));
            }
            catch
            {
                return false;
            }
        }

        private bool ImportFile(IFileAdapter adapter)
        {
            Fields.Clear();
            Adapter = adapter;

            var (headers, data) = Adapter.ResetAndReadHeadersAndData();
            if (data is null) return false;

            for (int i = 0; i < data.Length; i++)
            {
                var header = headers is null ? $"Header{i}" : headers[i];
                Fields.Add(new FieldOptions(header, i));
            }

            return true;
        }

        public void AddUnion()
            => Fields.Add(new Union($"Union{_unionCounter++}", " "));

        public void AddGuidField()
            => Fields.Add(new FieldOptions($"Guid{_unionCounter++}", 0, "{guid}")
            {
                Quotes = true
            });

        public void CopyField(IFieldOptions field)
        {
            Fields.Insert(
                Fields.IndexOf(field) + 1,
                field.Clone($"{field.Header}_Копия{_unionCounter++}"));
        }

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



        public string GetExampleString()
            => exporter.GetExample();

        public void ExportFile(string to)
        {
            using var sw = new StreamWriter(to);
            exporter.Export(sw);
        }

        public void Reset()
        {
            Adapter = new NullAdapter();
            Fields.Clear();
        }

        public void Dispose()
        {
            Adapter.Dispose();
        }
    }
}
