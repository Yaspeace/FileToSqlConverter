namespace ExcelToSqlConverter.Models
{
    public class FieldOptions : IFieldOptions
    {
        public string Header { get; set; } = "";
        public bool Quotes { get; set; }
        public int DataIndex { get; set; }

        public OptionsTypeEnum Type => OptionsTypeEnum.Field;

        public ICollection<IFieldOptions> Fields => new IFieldOptions[0];

        public FieldOptions(string header, int index)
        {
            Header = header;
            DataIndex = index;
        }

        public string GetFieldValue(string[] data)
        {
            string res = data[DataIndex];
            if (Quotes) res = $"'{res.Replace("'", "''")}'";
            return res;
        }
    }
}
