using ExcelToSqlConverter.Models.Fields;
using ExcelToSqlConverter.Models.Files;

namespace ExcelToSqlConverter.Models
{
    public interface IFieldsToFileHandler
    {
        public List<IFieldOptions> Fields { get; }

        public IFileAdapter Adapter { get; }
    }
}
