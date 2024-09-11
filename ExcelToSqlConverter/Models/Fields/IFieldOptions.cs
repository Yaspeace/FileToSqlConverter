namespace ExcelToSqlConverter.Models.Fields
{
    public interface IFieldOptions : IFields
    {
        string Header { get; set; }

        bool Quotes { get; set; }

        OptionsTypeEnum Type { get; }

        string GetFieldValue(string[] data, int rowNumber);

        IFieldOptions Clone(string newHeader);
    }
}
