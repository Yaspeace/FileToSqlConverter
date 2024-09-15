using ExcelToSqlConverter.Extensions;
using ExcelToSqlConverter.Models.Fields.Properties;
using ExcelToSqlConverter.Models.PropertyGroups;

namespace ExcelToSqlConverter.Models.Fields
{
    public class FieldOptions : IFieldOptions, IFieldProperties
    {
        public string Header { get; set; } = "";

        public bool Quotes { get; set; }

        public int DataIndex { get; set; }

        public Replacement Replacement { get; set; }

        public string Format { get; set; }

        public ArrayOptions? ArrayOptions { get; set; }

        public OptionsTypeEnum Type
            => OptionsTypeEnum.Field;

        public List<IFieldOptions> Fields
            => new();

        public FieldOptions(string header, int index, string format = "{value}")
        {
            Header = header;
            DataIndex = index;
            Format = format;

            // TODO: убрать
            ArrayOptions = new(",");
        }

        public string[] GetFieldValue(string[] data, int row)
        {
            var res = ArrayOptions is null
                ? new string[] { data[DataIndex] }
                : data[DataIndex].Split(ArrayOptions.Value.divider, StringSplitOptions.TrimEntries);

            for (int i = 0; i < res.Length; i++)
            {
                res[i] = res[i].CustomFormat(Format, row);

                if (!Replacement.Empty)
                    res[i] = res[i].Replace(Replacement.replace, Replacement.with);

                if (Quotes)
                    res[i] = res[i].SqlQuotes();
            }

            return res;
        }

        public void SetFromProperties(IFieldProperties props)
        {
            Header = props.Header;
            Quotes = props.Quotes;
            Replacement = props.Replacement;
            Format = props.Format;
            ArrayOptions = props.ArrayOptions;
        }

        public IFieldOptions Clone(string newHeader)
        {
            var clone = new FieldOptions(newHeader, DataIndex, Format);
            clone.SetFromProperties(this);
            clone.Header = newHeader;
            return clone;
        }
    }
}
