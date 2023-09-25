using IronXL;

namespace ExcelToSqlConverter.Models.Files
{
    public class ExcelFileAdapter : IFileAdapter
    {
        public bool End => _curRow >= maxRow; //_curRow >= _sheet.PhysicalRowCount;

        private int minCol;
        private int maxCol;
        private int minRow;
        private int maxRow;

        private WorkSheet _sheet;

        private int _curRow = 0;

        private WorkBook wb;

        public ExcelFileAdapter(string filename)
        {
            wb = WorkBook.Load(filename);
            _sheet = wb.DefaultWorkSheet;
            minRow = 0;
            maxRow = _sheet.PhysicalRowCount;
        }

        public ExcelFileAdapter(string filename, string listName)
        {
            wb = WorkBook.Load(filename);
            _sheet = wb.GetWorkSheet(listName);
        }

        public ExcelFileAdapter(string filename, int fromRow, int toRow, int fromCol, int toCol)
        {

        }

        public string[]? Read()
        {
            var cnt = _sheet.PhysicalColumnCount;
            var res = new string[cnt];
            for (int i = 0; i < cnt; i++)
            {
                res[i] = _sheet.GetCellAt(_curRow, i)?.Text ?? string.Empty;
            }
            _curRow++;
            return res;
        }

        public void Reset()
        {
            _curRow = 0;
        }

        public void Close()
        {
            wb.Close();
        }

        public void Dispose()
        {
            wb.Close();
        }
    }
}
