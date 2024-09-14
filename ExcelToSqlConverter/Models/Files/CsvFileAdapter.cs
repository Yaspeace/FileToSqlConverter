namespace ExcelToSqlConverter.Models.Files
{
    public class CsvFileAdapter : IFileAdapter
    {
        public bool End => _sr.EndOfStream;

        private readonly StreamReader _sr;

        private readonly char _splitter;

        private readonly string[]? _headers;

        public CsvFileAdapter(string filename, char splitter, bool headersLine)
        {
            _splitter = splitter;
            _sr = new StreamReader(filename);
            _headers = headersLine ? ReadNextData() : null;
        }

        public string[]? ReadNextData()
            => StringToData(_sr.ReadLine());

        public void Reset()
        {
            _sr.BaseStream.Position = 0;
            _sr.DiscardBufferedData();
            if (_headers != null) _sr.ReadLine();
        }

        public string[]? GetHeaders()
            => _headers;

        public void Dispose()
            => _sr.Dispose();

        private string[]? StringToData(string? str)
            => str?.Split(_splitter);
    }
}
