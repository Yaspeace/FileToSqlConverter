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
    }
}
