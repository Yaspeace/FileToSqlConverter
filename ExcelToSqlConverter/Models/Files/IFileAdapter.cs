namespace ExcelToSqlConverter.Models.Files
{
    public interface IFileAdapter : IDisposable
    {
        public bool End { get; }

        public string[]? Read();

        public void Reset();

        public string[]? ResetAndReadData();

        public string[]? ResetAndReadHeaders();

        public (string[]? headers, string[]? data) ResetAndReadHeadersAndData();

        void Close();
    }
}
