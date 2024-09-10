namespace ExcelToSqlConverter.Extensions
{
    public static class StringFormatter
    {
        public static string CustomFormat(this string selfFormat, int rowNumber, params object[] args)
        {
            selfFormat = selfFormat
                .Replace("{row}", rowNumber.ToString())
                .Replace("{guid}", Guid.NewGuid().ToString());

            for (int i = 0; i < args.Length; i++)
            {
                selfFormat = selfFormat.Replace($"{{{i + 1}}}", args[i].ToString());
            }

            return selfFormat;
        }

        public static string CustomFormat(this string valueString, string formatString, int rowNumber, params object[] args)
            => formatString.CustomFormat(rowNumber, args).Replace("{value}", valueString);

        public static string SqlQuotes(this string str)
            => $"'{str.Replace("'", "''")}'";
    }
}
