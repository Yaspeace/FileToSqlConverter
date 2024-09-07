namespace ExcelToSqlConverter.Models.Files
{
    public class NullAdapter : IFileAdapter
    {
        public bool End => true;

        public void Close()
        {
        }

        public void Dispose()
        {
        }

        public string[]? Read()
            => null;

        public void Reset()
        {
        }

        public string[]? ResetAndReadData()
            => null;

        public string[]? ResetAndReadHeaders()
            => null;

        public (string[]? headers, string[]? data) ResetAndReadHeadersAndData()
            => (null, null);
    }
}
