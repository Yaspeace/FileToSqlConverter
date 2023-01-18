using ExcelToSqlConverter.Models;

namespace ExcelToSqlConverter
{
    public partial class FieldPropertiesForm : Form
    {
        public string Header
        {
            get => headerTb.Text;
        }

        public bool Quotes
        {
            get => quotesCb.Checked;
        }
        public FieldPropertiesForm(IFieldOptions opt)
        {
            InitializeComponent();
            headerTb.Text = opt.Header;
            quotesCb.Checked = opt.Quotes;
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
