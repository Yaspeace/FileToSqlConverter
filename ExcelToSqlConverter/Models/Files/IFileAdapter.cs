namespace ExcelToSqlConverter.Models.Files
{
    public interface IFileAdapter : IDisposable
    {
        public bool End { get; }

        public string[]? ReadNextData();

        public string[]? GetHeaders();

        public void Reset();
    }
}
