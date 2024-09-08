namespace ExcelToSqlConverter
{
    public partial class CsvImportForm : Form
    {
        public char Splitter
            => customSplitterCb.Checked ? customSplitterTb.Text[0] : splitters[splitterCb.Text];

        public bool HeadersLine
            => headersLineCb.Checked;

        public string FileName
            => _fileDialog.FileName;

        private readonly Dictionary<string, char> splitters = new()
        {
            {"Запятая", ',' },
            {"Точка", '.' },
            {"Табуляция", '\t'},
            {"Пробел", ' '},
            {"Доллар", '$'},
            {"Двоеточие", ':'},
            { "Точка с запятой", ';'}
        };

        private readonly OpenFileDialog _fileDialog;

        public CsvImportForm(OpenFileDialog fileDialog)
        {
            InitializeComponent();

            _fileDialog = fileDialog;

            chosenFileNameLbl.Text = string.IsNullOrEmpty(_fileDialog.FileName)
                ? "Файл не выбран!"
                : _fileDialog.FileName;

            splitterCb.Items.AddRange(splitters.Keys.ToArray());
            splitterCb.SelectedIndex = 0;
        }

        private void customSplitterCb_CheckedChanged(object sender, EventArgs e)
        {
            customSplitterTb.Visible = customSplitterCb.Checked;
            splitterCb.Enabled = !customSplitterCb.Checked;
        }

        private void CloseFormEvent(object sender, EventArgs e)
        {
            Close();
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            if (_fileDialog.ShowDialog() != DialogResult.OK) return;

            chosenFileNameLbl.Text = _fileDialog.FileName;
        }
    }
}
