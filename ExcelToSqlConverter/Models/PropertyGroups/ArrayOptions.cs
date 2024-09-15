namespace ExcelToSqlConverter.Models.PropertyGroups
{
    public struct ArrayOptions
    {
        public string divider;

        public bool isNewLine;

        public ArrayOptions(string divider, bool isNewLine = true)
        {
            this.divider = divider;
            this.isNewLine = isNewLine;
        }
    }
}
