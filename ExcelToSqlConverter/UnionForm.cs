using ExcelToSqlConverter.Models.Fields;
using ExcelToSqlConverter.Models.Fields.Properties;

namespace ExcelToSqlConverter
{
    public partial class UnionForm : Form, IUnionProperties
    {
        public string Header
            => headerTb.Text;

        public bool Quotes
            => quotesCb.Checked;

        public string Separator
            => separatorRb.Checked ? mainTextBox.Text : string.Empty;

        public string FormatString
            => formatRb.Checked ? mainTextBox.Text : string.Empty;

        public bool FormatMode
            => formatRb.Checked;

        public UnionForm(IUnionProperties union)
        {
            InitializeComponent();

            headerTb.Text = union.Header;
            quotesCb.Checked = union.Quotes;
            
            if (union.FormatMode)
            {
                formatRb.Checked = true;
                mainTextBox.Text = union.FormatString;
            }
            else
            {
                separatorRb.Checked = true;
                mainTextBox.Text = union.Separator;
            }
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
