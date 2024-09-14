using OfficeOpenXml;

namespace ExcelToSqlConverter.Models.Files
{
    public class OpenOffiseExcelFileAdapter : IFileAdapter
    {
        public bool End => _curRow > _ws.Dimension.End.Row;

        private readonly bool _headersLine;

        private readonly ExcelPackage _pack;
        private readonly ExcelWorksheet _ws;
        int _curRow = 1;

        public OpenOffiseExcelFileAdapter(string filename, bool headersLine, string listName = "")
        {
            _pack = new ExcelPackage(filename);
            _ws = string.IsNullOrEmpty(listName)
                ? _pack.Workbook.Worksheets[0]
                : _pack.Workbook.Worksheets[listName];
            _headersLine = headersLine;
        }

        public string[]? GetHeaders()
            => _headersLine ? ReadRow(1) : null;

        public string[]? ReadNextData()
            => End ? null : ReadRow(_curRow++);

        public void Reset()
            => _curRow = _headersLine ? 2 : 1;

        public void Dispose()
            => _pack.Dispose();

        private string[]? ReadRow(int row)
            => Enumerable
                .Range(1, _ws.Columns.EndColumn)
                .Select(colIdx => _ws.Cells[row, colIdx].Value?.ToString() ?? string.Empty)
                .ToArray();
    }
}
