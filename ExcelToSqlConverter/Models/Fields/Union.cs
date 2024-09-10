using ExcelToSqlConverter.Extensions;
using ExcelToSqlConverter.Models.Fields.Properties;

namespace ExcelToSqlConverter.Models.Fields
{
    public class Union : IFieldOptions, IUnionProperties
    {
        public string Header { get; set; } = "";

        public ICollection<IFieldOptions> Fields { get; set; }

        public string Separator { get; set; } = "";

        public bool Quotes { get; set; }

        public bool FormatMode { get; set; }

        public string FormatString { get; set; } = string.Empty;

        public OptionsTypeEnum Type
            => OptionsTypeEnum.Union;

        public Union(string header, string separator)
        {
            Header = header;
            Separator = separator;
            Fields = new List<IFieldOptions>();
        }

        public string GetFieldValue(string[] data, int rowNumber)
        {
            var fieldValues = Fields.Select(x => x.GetFieldValue(data, rowNumber)).ToArray();

            var res = FormatMode
                ? FormatString.CustomFormat(rowNumber, fieldValues)
                : string.Join(Separator, fieldValues);

            return Quotes
                ? res.SqlQuotes()
                : res;
        }

        public void SetFromProperties(IUnionProperties props)
        {
            Header = props.Header;
            Separator = props.Separator;
            Quotes = props.Quotes;
            FormatMode = props.FormatMode;
            FormatString = props.FormatString;
        }
    }
}
