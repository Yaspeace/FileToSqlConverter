using ExcelToSqlConverter.Models.Fields;

namespace ExcelToSqlConverter.Models
{
    public interface IFields
    {
        List<IFieldOptions> Fields { get; }
    }
}
