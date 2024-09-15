using ExcelToSqlConverter.Helpers;

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
            _handler.Adapter.Reset();
            var data = _handler.Adapter.ReadNextData();

            if (data is null) return;

            int rowNum = 1;
            stream.Write($"(values\n\t{ConcatRecordsFromData(data, rowNum++)}");

            while (!_handler.Adapter.End)
            {
                data = _handler.Adapter.ReadNextData();
                if (data == null) break;

                stream.Write($",\n\t{ConcatRecordsFromData(data, rowNum++)}");
            }

            stream.Write($"\n) as source({GetHeadersString()})");
        }

        public string GetExample()
        {
            _handler.Adapter.Reset();
            var data = _handler.Adapter.ReadNextData();

            if (data is null) return string.Empty;

            return $"{RecordsFromData(data, 1)[0]} as source({GetHeadersString()})";
        }

        private string ConcatRecordsFromData(string[] data, int row)
            => ConcatRecords(RecordsFromData(data, row));

        private string[] RecordsFromData(string[] data, int row)
        {
            var fieldValuesArr = _handler.Fields.Select(x => x.GetFieldValue(data, row)).ToArray();

            return CollectionOperations.CrossJoin(fieldValuesArr)
                .Select(vals => $"({string.Join(',', vals)})")
                .ToArray();
        }

        private string ConcatRecords(string[] records)
            => string.Join(",\n\t", records);

        private string GetHeadersString()
            => string.Join(',', _handler.Fields.Select(x => x.Header));
    }
}
