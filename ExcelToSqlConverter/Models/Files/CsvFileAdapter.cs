namespace ExcelToSqlConverter.Models.Files
{
    public class CsvFileAdapter : IFileAdapter
    {
        private StreamReader _sr;

        private char _splitter;

        private string _filename;

        public bool End => _sr.EndOfStream;

        public CsvFileAdapter(string filename, char splitter)
        {
            _splitter = splitter;
            _sr = new StreamReader(filename);
            _filename = filename;
        }

        public string[]? Read()
        {
            return _sr.ReadLine()?.Split(_splitter);
        }

        public void Reset()
        {
            _sr = new StreamReader(_filename);
        }

        public void Close()
        {
            _sr.Close();
        }
    }
}
