using System;
using ExcelToSqlConverter.Extensions;
using ExcelToSqlConverter.Helpers;
using ExcelToSqlConverter.Models.Fields.Properties;
using ExcelToSqlConverter.Models.PropertyGroups;

namespace ExcelToSqlConverter.Models.Fields
{
    public class Union : IFieldOptions, IUnionProperties
    {
        public string Header { get; set; } = "";

        public List<IFieldOptions> Fields { get; set; } = new();

        public string Separator { get; set; } = "";

        public bool Quotes { get; set; }

        public bool FormatMode { get; set; }

        public string FormatString { get; set; } = string.Empty;

        public ArrayOptions? ArrayOptions => null;

        public OptionsTypeEnum Type
            => OptionsTypeEnum.Union;

        public Union(string header, string separator)
        {
            Header = header;
            Separator = separator;
        }

        public string[] GetFieldValue(string[] data, int row)
        {
            var fieldValues = Fields.Select(x => x.GetFieldValue(data, row)).ToArray();
            var results = new List<string>();
            foreach (var values in CollectionOperations.CrossJoin(fieldValues))
            {
                var res = FormatMode
                    ? FormatString.CustomFormat(row, values)
                    : string.Join(Separator, values);

                results.Add(Quotes ? res.SqlQuotes() : res);
            }

            return results.ToArray();
        }

        public void SetFromProperties(IUnionProperties props)
        {
            Header = props.Header;
            Separator = props.Separator;
            Quotes = props.Quotes;
            FormatMode = props.FormatMode;
            FormatString = props.FormatString;
        }

        public IFieldOptions Clone(string newHeader)
        {
            var clone = new Union(newHeader, Separator);
            clone.SetFromProperties(this);
            clone.Header = newHeader;
            return clone;
        }
    }
}
