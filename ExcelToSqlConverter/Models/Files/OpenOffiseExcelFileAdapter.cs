using OfficeOpenXml;

namespace ExcelToSqlConverter.Models.Files
{
    public class OpenOffiseExcelFileAdapter : IFileAdapter
    {
        public bool End => curRow == ws.Dimension.End.Row;

        private readonly ExcelPackage pack;
        private readonly ExcelWorksheet ws;
        int curRow = 1;

        public OpenOffiseExcelFileAdapter(string filename)
        {
            pack = new ExcelPackage(filename);
            ws = pack.Workbook.Worksheets[0];
        }

        public OpenOffiseExcelFileAdapter(string filename, string listName)
        {
            pack = new ExcelPackage(filename);
            ws = pack.Workbook.Worksheets[listName];
        }

        public string[]? Read()
        {
            if (End) return null;

            var colNum = ws.Columns.EndColumn;

            var res = Enumerable
                .Range(1, colNum)
                .Select(colIdx => ws.Cells[curRow, colIdx].Value?.ToString() ?? string.Empty)
                .ToArray();
            ++curRow;

            return res;
        }

        public void Reset() => curRow = 1;

        public void Close()
        {
            
        }

        public void Dispose()
        {
            pack.Dispose();
        }
    }
}
