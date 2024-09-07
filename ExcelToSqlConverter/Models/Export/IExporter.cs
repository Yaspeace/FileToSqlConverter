namespace ExcelToSqlConverter.Models.Export
{
    public interface IExporter
    {
        public void Export(StreamWriter stream);

        public string GetExample();
    }
}
