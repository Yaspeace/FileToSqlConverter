namespace ExcelToSqlConverter.Models.Files
{
    public interface IFileAdapter : IDisposable
    {
        public bool End { get; }
        public string[]? Read();
        public void Reset();
        void Close();
    }
}
