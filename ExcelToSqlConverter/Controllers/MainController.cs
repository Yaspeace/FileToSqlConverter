using ExcelToSqlConverter.Models;
using ExcelToSqlConverter.Models.Files;

namespace ExcelToSqlConverter.Controllers
{
    public class MainController
    {
        public ICollection<IFieldOptions> Fields { get; set; }

        private GuidField guidField;

        private string[]? cachedData;

        private IFileAdapter? adapter;

        private bool headersLine;

        public MainController()
        {
            Fields = new List<IFieldOptions>();
            guidField = new GuidField("Guid");
        }

        public void ImportCsv(string filename, char splitter, bool headersLine)
        {
            this.adapter = new CsvFileAdapter(filename, splitter);
            ImportFile(adapter, headersLine);
        }

        public void ImportExcel(string filename, string listName, bool headersLine)
        {
            this.adapter = new ExcelFileAdapter(filename, listName);
            ImportFile(adapter, headersLine);
        }

        public void ImportExcelDefault(string filename, bool headersLine)
        {
            this.adapter = new ExcelFileAdapter(filename);
            ImportFile(adapter, headersLine);
        }

        private void ImportFile(IFileAdapter adapter, bool headersLine)
        {
            Fields.Clear();
            this.headersLine = headersLine;

            var data = adapter.Read() ?? new string[0];
            for (int i = 0; i < data.Length; i++)
            {
                var header = headersLine ? data[i] : "Header" + i;
                Fields.Add(new FieldOptions(header, i));
            }
            cachedData = data;
            if (headersLine) cachedData = adapter.Read();
        }

        public void AddUnion(string header, string splitter)
        {
            Fields.Add(new Union(header, splitter));
        }

        public void PlaceTo(object obj, object to)
        {
            if (obj is not IFieldOptions || to is not IFieldOptions) return;
            var objOpt = (obj as IFieldOptions) ?? throw new Exception("aboba");
            var toOpt = (to as IFieldOptions) ?? throw new Exception("abeba");
            if (objOpt.Type != OptionsTypeEnum.Field || toOpt.Type != OptionsTypeEnum.Union) return;

            toOpt.Fields.Add(objOpt);
            Fields.Remove(objOpt);
        }

        public void Remove(object obj)
        {
            var opt = obj as IFieldOptions;
            if (opt == null) return;

            if (opt.Type == OptionsTypeEnum.Union)
            {
                foreach (var f in opt.Fields)
                    Fields.Add(f);
            }
            Fields.Remove(opt);
        }

        public void Move(object obj, bool up)
        {
            var field = obj as IFieldOptions;
            if (field == null) return;

            if (!Fields.Any() || !Fields.Contains(field)) return;
            if (up && field == Fields.First()) return;
            if (!up && field == Fields.Last()) return;

            var arr = Fields.ToArray();
            int i = 0;
            while (arr[i] != field) i++;

            if (up)
            {
                var tmp = arr[i - 1];
                arr[i - 1] = field;
                arr[i] = tmp;
            }
            else
            {
                var tmp = arr[i + 1];
                arr[i + 1] = field;
                arr[i] = tmp;
            }

            Fields = arr.ToList();
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
            var headers = GetHeaders();

            res += " as source(";
            var first = true;
            foreach (var head in headers)
            {
                if (!first) res += ",";
                res += head;
                first = false;
            }
            res += ")";
            return res;
        }

        private string[] GetHeaders()
        {
            return Fields.Select(x => x.Header).ToArray();
        }

        private string RecordFromData(string[] data)
        {
            var res = "(";
            var first = true;
            
            foreach(var field in Fields)
            {
                if (!first) res += ",";
                res += field.GetFieldValue(data);
                first = false;
            }
            res += ")";
            return res;
        }

        public void ExportFile(string to)
        {
            /*using (var sw = new StreamWriter(to))
            using (var sr = new StreamReader(from))
            {
                var line = sr.ReadLine();
                if (headersLine) line = sr.ReadLine();
                sw.Write("(values\n");

                var data = line.Trim().Split(splitter);
                var record = RecordFromData(data);
                sw.Write("\t" + record);
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (line == null) break;
                    data = line.Trim().Split(splitter);
                    record = RecordFromData(data);
                    sw.Write(",\n");
                    sw.Write("\t" + record);
                }
                var headers = GetHeaders();
                var headersStr = "source(";
                var first = true;
                foreach (var head in headers)
                {
                    if (!first) headersStr += ",";
                    headersStr += head;
                    first = false;
                }
                headersStr += ")";
                sw.Write("\n) as " + headersStr);
            }*/
            if (adapter == null)
                throw new Exception("Adapter is null!");
            adapter.Reset();

            using (var sw = new StreamWriter(to))
            {
                var data = adapter.Read();
                if (headersLine) data = adapter.Read();
                sw.Write("(values\n");
                var record = RecordFromData(data);
                sw.Write("\t" + record);
                while (!adapter.End)
                {
                    data = adapter.Read();
                    if (data == null) break;
                    record = RecordFromData(data);
                    sw.Write(",\n");
                    sw.Write("\t" + record);
                }

                var headers = GetHeaders();
                var headersStr = "source(";
                var first = true;
                foreach (var head in headers)
                {
                    if (!first) headersStr += ",";
                    headersStr += head;
                    first = false;
                }
                headersStr += ")";
                sw.Write("\n) as " + headersStr);
            }
        }
    }
}
