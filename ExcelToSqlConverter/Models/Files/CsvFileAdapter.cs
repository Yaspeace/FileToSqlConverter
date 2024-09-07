namespace ExcelToSqlConverter.Models.Files
{
    public class CsvFileAdapter : IFileAdapter
    {
        public bool End => _sr.EndOfStream;

        public bool HeadersLine { get; private set; }

        private StreamReader _sr;

        private char _splitter;

        private string _filename;

        public CsvFileAdapter(string filename, char splitter, bool headersLine)
        {
            _splitter = splitter;
            _sr = new StreamReader(filename);
            _filename = filename;
            HeadersLine = headersLine;
        }

        public string[]? Read()
            => _sr.ReadLine()?.Split(_splitter);

        public void Reset()
            => _sr = new StreamReader(_filename);

        public string[]? ResetAndReadData()
        {
            Reset();
            var data = Read();
            if (HeadersLine) data = Read();

            return data;
        }

        public string[]? ResetAndReadHeaders()
        {
            Reset();
            return HeadersLine ? Read() : null;
        }

        public (string[]? headers, string[]? data) ResetAndReadHeadersAndData()
        {
            Reset();
            var data = Read();
            return HeadersLine
                ? (data, Read())
                : (null, data);
        }

        public void Close()
            => _sr.Close();

        public void Dispose()
            => _sr.Dispose();
    }
}
