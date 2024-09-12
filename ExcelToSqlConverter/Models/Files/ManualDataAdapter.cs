namespace ExcelToSqlConverter.Models.Files
{
    public class ManualDataAdapter : IFileAdapter
    {
        private int curRow = 0;

        public bool End => curRow > ManualDataStorage.Data.Rows.Count - 1;

        public void Close()
        {
        }

        public void Dispose()
        {
        }

        public string[]? Read()
        {
            if (End) return null;

            var res = ManualDataStorage.Data.Rows[curRow].ItemArray?
                .Select(obj => obj?.ToString() ?? string.Empty)
                .ToArray();
            ++curRow;
            return res;
        }

        public void Reset()
        {
            curRow = 0;
        }

        public string[]? ResetAndReadData()
        {
            Reset();
            return Read();
        }

        public string[]? ResetAndReadHeaders()
        {
            Reset();
            return GetHeaders();
        }

        public (string[]? headers, string[]? data) ResetAndReadHeadersAndData()
        {
            Reset();
            return (GetHeaders(), Read());
        }

        private string[] GetHeaders()
        {
            var headers = new List<string>();
            for (int i = 0; i < ManualDataStorage.Data.Columns.Count; i++)
                headers.Add(ManualDataStorage.Data.Columns[i].ColumnName);
            return headers.ToArray();
        }
    }
}
