using ExcelToSqlConverter.Models;

namespace ExcelToSqlConverter
{
    public partial class UnionForm : Form
    {
        public string Header
        {
            get => headerTb.Text;
        }

        public bool Quotes
        {
            get => quotesCb.Checked;
        }

        public string Splitter
        {
            get => splitterTb.Text;
        }
        public UnionForm(Union uni)
        {
            InitializeComponent();
            headerTb.Text = uni.Header;
            quotesCb.Checked = uni.Quotes;
            splitterTb.Text = uni.Separator;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
