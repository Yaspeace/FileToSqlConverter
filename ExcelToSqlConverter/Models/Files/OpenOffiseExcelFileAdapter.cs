using OfficeOpenXml;

namespace ExcelToSqlConverter.Models.Files
{
    public class OpenOffiseExcelFileAdapter : IFileAdapter
    {
        public bool End => curRow > ws.Dimension.End.Row;

        public bool HeadersLine { get; private set; }

        private readonly ExcelPackage pack;
        private readonly ExcelWorksheet ws;
        int curRow = 1;

        public OpenOffiseExcelFileAdapter(string filename, bool headersLine, string listName = "")
        {
            pack = new ExcelPackage(filename);
            ws = string.IsNullOrEmpty(listName)
                ? pack.Workbook.Worksheets[0]
                : pack.Workbook.Worksheets[listName];
            HeadersLine = headersLine;
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

        public void Reset()
            => curRow = 1;

        public string[]? ResetAndReadData()
        {
            Reset();
            var data = Read();
            if (HeadersLine) data = Read();

            return data;
        }

        public string[]? ResetAndReadHeaders()
        {
            Reset();
            return HeadersLine ? Read() : null;
        }

        public (string[]? headers, string[]? data) ResetAndReadHeadersAndData()
        {
            Reset();
            var data = Read();
            return HeadersLine
                ? (data, Read())
                : (null, data);
        }

        public void Close()
        {

        }

        public void Dispose()
            => pack.Dispose();
    }
}
