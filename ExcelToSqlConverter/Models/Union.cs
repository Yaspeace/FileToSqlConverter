using System.Text;

namespace ExcelToSqlConverter.Models
{
    public class Union : IFieldOptions
    {
        public string Header { get; set; } = "";

        public ICollection<IFieldOptions> Fields { get; set; }

        public string Separator { get; set; } = "";

        public bool Quotes { get; set; }

        public OptionsTypeEnum Type => OptionsTypeEnum.Union;

        public Union(string header, string separator)
        {
            Header = header;
            Separator = separator;
            Fields = new List<IFieldOptions>();
        }

        public string GetFieldValue(string[] data)
        {
            var sb = new StringBuilder();
            if (Quotes) sb.Append("'");
            var first = true;
            foreach (var field in Fields)
            {
                if (!first) sb.Append(Separator);
                sb.Append(field.GetFieldValue(data));
                first = false;
            }
            if (Quotes) sb.Append("'");
            return sb.ToString();
        }
    }
}
