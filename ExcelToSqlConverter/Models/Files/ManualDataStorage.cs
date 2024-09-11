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
    }
}
