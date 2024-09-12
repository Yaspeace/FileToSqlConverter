using ExcelToSqlConverter.Models.Files;

namespace ExcelToSqlConverter.Forms.Imports
{
    public partial class ManualImportForm : Form
    {
        public ManualImportForm()
        {
            InitializeComponent();
            grid.DataSource = ManualDataStorage.Data;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ManualDataStorage.Data.Columns.Add();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var idx = new SortedSet<int>(Enumerable
                .Range(0, grid.SelectedCells.Count)
                .Select(i => grid.SelectedCells[i].ColumnIndex))
                .Reverse();

            foreach (var i in idx)
            {
                ManualDataStorage.Data.Columns.RemoveAt(i);
            }
        }

        private void HandlePaste(bool isHeaders)
        {
            if (grid.SelectedCells.Count == 0) return;

            var curcell = grid.SelectedCells[0];

            ManualDataStorage.InsertValues(
                curcell.ColumnIndex,
                curcell.RowIndex,
                GetArrayByText(Clipboard.GetText()),
                isHeaders);
        }

        private static string[][] GetArrayByText(string text)
        {
            return text
                .Replace("\r\n", "\n")
                .Split('\n')
                .Select(x => x.Split('\t'))
                .ToArray();
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                var dialogRes = MessageBox.Show(
                    "Вставить с заголовками?",
                    string.Empty,
                    MessageBoxButtons.YesNoCancel);

                if (dialogRes == DialogResult.Cancel) return;

                HandlePaste(dialogRes == DialogResult.Yes);
            }
        }
    }
}
