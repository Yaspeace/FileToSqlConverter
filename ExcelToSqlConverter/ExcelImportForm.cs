namespace ExcelToSqlConverter
{
    public partial class ExcelImportForm : Form
    {
        public string ListName => listTb.Text;

        public bool HeadersLine => headersCb.Checked;

        public bool DefaultList => defaultListCb.Checked;

        public ExcelImportForm()
        {
            InitializeComponent();
        }

        private void CloseFormEvent(object sender, EventArgs e)
        {
            Close();
        }

        private void defaultListCb_CheckedChanged(object sender, EventArgs e)
        {
            listTb.Enabled = !defaultListCb.Checked;
        }
    }
}
