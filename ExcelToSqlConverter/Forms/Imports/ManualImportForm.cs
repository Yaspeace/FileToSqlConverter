using ExcelToSqlConverter.Models.Files;

namespace ExcelToSqlConverter.Forms.Imports
{
    public partial class ManualImportForm : Form
    {
        public ManualImportForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = ManualDataStorage.Data;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ManualDataStorage.Data.Columns.Add();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var idx = new SortedSet<int>(Enumerable
                .Range(0, dataGridView1.SelectedCells.Count)
                .Select(i => dataGridView1.SelectedCells[i].ColumnIndex))
                .Reverse();

            foreach (var i in idx)
            {
                ManualDataStorage.Data.Columns.RemoveAt(i);
            }
        }
    }
}
