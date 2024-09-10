namespace ExcelToSqlConverter.Models.Fields.Properties
{
    public interface IUnionProperties
    {
        string Header { get; }

        bool Quotes { get; }

        string Separator { get; }

        bool FormatMode { get; }

        string FormatString { get; }
    }
}
