namespace ExcelToSqlConverter.Models.Export
{
    public class ValuesExporter : IExporter
    {
        private readonly IFieldsToFileHandler _handler;

        public ValuesExporter(IFieldsToFileHandler handler)
        {
            _handler = handler;
        }

        public void Export(StreamWriter stream)
        {
            var data = _handler.Adapter.ResetAndReadData();

            if (data is null) return;

            stream.Write($"(values\n\t{RecordFromData(data)}");

            while (!_handler.Adapter.End)
            {
                data = _handler.Adapter.Read();
                if (data == null) break;

                stream.Write($",\n\t{RecordFromData(data)}");
            }

            stream.Write($"\n) as source({GetHeadersString()})");
        }

        public string GetExample()
        {
            var data = _handler.Adapter.ResetAndReadData();

            if (data is null) return string.Empty;

            return $"{RecordFromData(data)} as source({GetHeadersString()})";
        }

        public string RecordFromData(string[] data)
        {
            var fieldValuesArr = _handler.Fields.Select(x => x.GetFieldValue(data)).ToArray();
            return $"({string.Join(',', fieldValuesArr)})";
        }

        private string GetHeadersString()
            => string.Join(',', _handler.Fields.Select(x => x.Header));
    }
}
