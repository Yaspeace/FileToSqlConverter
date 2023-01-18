namespace ExcelToSqlConverter.Models
{
    public class GuidField : IFieldOptions
    {
        public string Header { get; set; } = "";
        public bool Quotes { get; set; }

        public OptionsTypeEnum Type => OptionsTypeEnum.Field;

        public ICollection<IFieldOptions> Fields => new IFieldOptions[0];

        public GuidField(string header)
        {
            Header = header;
        }

        public string GetFieldValue(string[] data)
        {
            var res = Guid.NewGuid().ToString();
            if (Quotes) res = $"'{res}'";
            return res;
        }
    }
}
