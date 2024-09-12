using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToSqlConverter.Controls
{
    public class TableGridView : DataGridView
    {
        private const int WM_PASTE = 0x0302;

        private readonly DataTable _table;

        private new object DataSource;

        public TableGridView()
        {
            _table = new();
            DataSource = _table;
            AllowUserToAddRows = true;
            AllowUserToDeleteRows = true;
            AllowUserToResizeColumns = true;
            AllowUserToResizeRows = true;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PASTE)
            {
                HandlePaste(Clipboard.GetText());
            }

            base.WndProc(ref m);
        }

        private void HandlePaste(string clipboardText)
        {
            if (SelectedCells.Count == 0) return;

            var curcell = SelectedCells[0];
            var data = GetArrayByText(clipboardText);
            if (data.Length == 0) return;

            while (_table.Columns.Count < curcell.ColumnIndex + data[0].Length)
                _table.Columns.Add();

            while (_table.Rows.Count < curcell.RowIndex + data.Length)
                _table.Rows.Add();

            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    _table.Rows[i + curcell.RowIndex][j + curcell.ColumnIndex]
                        = data[i][j];
                }
            }
        }

        private string[][] GetArrayByText(string text)
        {
            return text.Split('\n')
                .Select(x => x.Split('\t'))
                .ToArray();
        }
    }
}
