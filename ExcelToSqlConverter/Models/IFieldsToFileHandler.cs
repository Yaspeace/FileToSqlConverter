using ExcelToSqlConverter.Models.Files;

namespace ExcelToSqlConverter.Models
{
    public interface IFieldsToFileHandler : IFields
    {
        public IFileAdapter Adapter { get; }
    }
}
