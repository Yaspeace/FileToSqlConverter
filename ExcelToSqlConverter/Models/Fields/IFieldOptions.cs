using ExcelToSqlConverter.Models.PropertyGroups;

namespace ExcelToSqlConverter.Models.Fields
{
    public interface IFieldOptions : IFields
    {
        string Header { get; set; }

        ArrayOptions? ArrayOptions { get; }

        OptionsTypeEnum Type { get; }

        string[] GetFieldValue(string[] data, int row);

        IFieldOptions Clone(string newHeader);
    }
}
