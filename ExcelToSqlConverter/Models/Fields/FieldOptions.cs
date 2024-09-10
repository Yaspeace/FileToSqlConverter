using ExcelToSqlConverter.Extensions;
using ExcelToSqlConverter.Models.Fields.Properties;

namespace ExcelToSqlConverter.Models.Fields
{
    public class FieldOptions : IFieldOptions, IFieldProperties
    {
        public string Header { get; set; } = "";

        public bool Quotes { get; set; }

        public int DataIndex { get; set; }

        public Replacement Replacement { get; set; }

        public string Format { get; set; }

        public OptionsTypeEnum Type
            => OptionsTypeEnum.Field;

        public ICollection<IFieldOptions> Fields
            => Array.Empty<IFieldOptions>();

        public FieldOptions(string header, int index, string format = "{value}", Replacement replacement = new())
        {
            Header = header;
            DataIndex = index;
            Format = format;
            Replacement = replacement;
        }

        public string GetFieldValue(string[] data, int rowNumber)
        {
            var res = data[DataIndex].CustomFormat(Format, rowNumber);

            if (!Replacement.Empty)
                res = res.Replace(Replacement.replace, Replacement.with);

            if (Quotes)
                res = res.SqlQuotes();

            return res;
        }

        public void SetFromProperties(IFieldProperties props)
        {
            Header = props.Header;
            Quotes = props.Quotes;
            Replacement = props.Replacement;
            Format = props.Format;
        }

        public IFieldOptions Clone(string newHeader)
        {
            var clone = new FieldOptions(newHeader, DataIndex, Format, Replacement);
            clone.SetFromProperties(this);
            clone.Header = newHeader;
            return clone;
        }
    }
}
