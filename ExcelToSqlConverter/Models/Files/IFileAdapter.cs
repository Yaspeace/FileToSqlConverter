namespace ExcelToSqlConverter.Models.Files
{
    public interface IFileAdapter
    {
        public bool End { get; }
        public string[]? Read();
        public void Reset();
        void Close();
    }
}
