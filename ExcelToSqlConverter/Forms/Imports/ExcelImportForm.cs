using ExcelToSqlConverter.Enums;

namespace ExcelToSqlConverter.Forms.Imports
{
    public partial class ExcelImportForm : Form
    {
        public string ListName
            => listTb.Text;

        public bool HeadersLine
            => headersCb.Checked;

        public bool DefaultList
            => defaultListCb.Checked;

        public string FileName
            => _fileDialog.FileName;

        private readonly OpenFileDialog _fileDialog;

        public ExcelImportForm(OpenFileDialog fileDialog)
        {
            InitializeComponent();

            _fileDialog = fileDialog;

            okBtn.Enabled = !string.IsNullOrEmpty(_fileDialog.FileName);
            fileNameLbl.Text = string.IsNullOrEmpty(_fileDialog.FileName)
                ? UIStrings.FileNotChosen
                : _fileDialog.FileName;
        }

        private void CloseFormEvent(object sender, EventArgs e)
        {
            Close();
        }

        private void defaultListCb_CheckedChanged(object sender, EventArgs e)
        {
            listTb.Enabled = !defaultListCb.Checked;
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            if (_fileDialog.ShowDialog() != DialogResult.OK) return;

            fileNameLbl.Text = _fileDialog.FileName;
            okBtn.Enabled = true;
        }
    }
}
