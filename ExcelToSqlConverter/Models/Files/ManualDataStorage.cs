using System.Data;

namespace ExcelToSqlConverter.Models.Files
{
    public static class ManualDataStorage
    {
        private static readonly DataTable _data = new();

        public static DataTable Data
        {
            get
            {
                if (_data.Columns.Count == 0)
                {
                    _data.Columns.Add();
                }

                return _data;
            }
        }

        public static void InsertValues(int startColIdx, int startRowIdx, string[][] values, bool headers = false)
        {
            var minAbleRows = headers ? 2 : 1;
            if (values.Length < minAbleRows || values[0].Length == 0)
                return;

            var dataRowsCount = headers ? values.Length - 1 : values.Length;
            var dataColsCount = values[0].Length;

            while (Data.Columns.Count < startColIdx + dataColsCount)
                Data.Columns.Add();
            while (Data.Rows.Count < startRowIdx + dataRowsCount)
                Data.Rows.Add();

            if (headers)
            {
                for (int i = 0; i < values[0].Length; i++)
                {
                    Data.Columns[startColIdx + i].ColumnName = GetUniqueColName(values[0][i]);
                }
            }

            int dataStartIdx = headers ? 1 : 0;
            for (int i = dataStartIdx; i < values.Length; i++)
                for (int j = 0; j < values[i].Length; j++)
                    Data.Rows[startRowIdx + i - dataStartIdx][startColIdx + j] = values[i][j];
        }

        private static string GetUniqueColName(string name)
        {
            if (!Data.Columns.Contains(name))
            {
                return name;
            }

            int num = 1;
            while (Data.Columns.Contains($"{name}{num}")) num++;

            return $"{name}{num}";
        }
    }
}
