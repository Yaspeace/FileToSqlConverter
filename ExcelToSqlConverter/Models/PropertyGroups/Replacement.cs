namespace ExcelToSqlConverter.Models.PropertyGroups
{
    /// <summary>
    /// Параметры замены строк.
    /// </summary>
    public struct Replacement
    {
        /// <summary>
        /// Что заменять.
        /// </summary>
        public string replace;

        /// <summary>
        /// На что заменять.
        /// </summary>
        public string with;

        public Replacement(string replace, string with)
        {
            this.replace = replace;
            this.with = with;
        }

        public readonly bool Empty
            => string.IsNullOrEmpty(replace) && string.IsNullOrEmpty(with);
    }
}
