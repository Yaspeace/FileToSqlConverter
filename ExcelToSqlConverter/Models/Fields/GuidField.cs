namespace ExcelToSqlConverter.Models.Fields
{
    public class GuidField : IFieldOptions
    {
        public string Header { get; set; } = "";

        public bool Quotes { get; set; } = true;

        public OptionsTypeEnum Type => OptionsTypeEnum.Field;

        public ICollection<IFieldOptions> Fields => Array.Empty<IFieldOptions>();

        public GuidField(string header)
        {
            Header = header;
        }

        public string GetFieldValue(string[] data)
        {
            var guid = Guid.NewGuid().ToString();
            return Quotes ? $"'{guid}'" : guid;
        }
    }
}
