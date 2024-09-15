using ExcelToSqlConverter.Models.PropertyGroups;

namespace ExcelToSqlConverter.Models.Fields.Properties
{
    public interface IFieldProperties
    {
        string Header { get; }

        bool Quotes { get; }

        Replacement Replacement { get; }

        string Format { get; }

        ArrayOptions? ArrayOptions { get; }
    }
}
