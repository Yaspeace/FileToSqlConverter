namespace ExcelToSqlConverter.Models.Files
{
    public class NullAdapter : IFileAdapter
    {
        public bool End => true;

        public void Dispose() { }

        public string[]? GetHeaders() => null;

        public string[]? ReadNextData() => null;

        public void Reset() { }
    }
}
