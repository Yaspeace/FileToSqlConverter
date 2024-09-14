namespace ExcelToSqlConverter.Models.Files
{
    public class ManualDataAdapter : IFileAdapter
    {
        public bool End
            => _curRow > ManualDataStorage.Data.Rows.Count - 1;

        private int _curRow = 0;

        public void Dispose() { }

        public string[]? GetHeaders()
        {
            var headers = new List<string>();
            for (int i = 0; i < ManualDataStorage.Data.Columns.Count; i++)
                headers.Add(ManualDataStorage.Data.Columns[i].ColumnName);

            return headers.ToArray();
        }

        public string[]? ReadNextData()
        {
            if (End) return null;

            var res = ManualDataStorage.Data.Rows[_curRow].ItemArray?
                .Select(obj => obj?.ToString() ?? string.Empty)
                .ToArray();
            ++_curRow;
            return res;
        }

        public void Reset()
            => _curRow = 0;
    }
}
