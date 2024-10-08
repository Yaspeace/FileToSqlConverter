﻿namespace ExcelToSqlConverter.Models.Export
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
            stream.Write($"(values\n\t{RecordFromData(data, rowNum++)}");

            while (!_handler.Adapter.End)
            {
                data = _handler.Adapter.ReadNextData();
                if (data == null) break;

                stream.Write($",\n\t{RecordFromData(data, rowNum++)}");
            }

            stream.Write($"\n) as source({GetHeadersString()})");
        }

        public string GetExample()
        {
            _handler.Adapter.Reset();
            var data = _handler.Adapter.ReadNextData();

            if (data is null) return string.Empty;

            return $"{RecordFromData(data, 1)} as source({GetHeadersString()})";
        }

        private string RecordFromData(string[] data, int rowNumber)
        {
            var fieldValuesArr = _handler.Fields.Select(x => x.GetFieldValue(data, rowNumber)).ToArray();
            return $"({string.Join(',', fieldValuesArr)})";
        }

        private string GetHeadersString()
            => string.Join(',', _handler.Fields.Select(x => x.Header));
    }
}
