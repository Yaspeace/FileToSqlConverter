using ExcelToSqlConverter.Models;
using ExcelToSqlConverter.Models.Fields;
using ExcelToSqlConverter.Models.Fields.Properties;

namespace ExcelToSqlConverter
{
    public partial class FieldPropertiesForm : Form, IFieldProperties
    {
        public string Header
            => headerTb.Text;

        public bool Quotes
            => quotesCb.Checked;

        public Replacement Replacement
            => new(replaceTb.Text, replaceWithTb.Text);

        public string Format
            => formatTb.Text;

        public FieldPropertiesForm(IFieldProperties opt)
        {
            InitializeComponent();

            headerTb.Text = opt.Header;
            quotesCb.Checked = opt.Quotes;
            formatTb.Text = opt.Format;
            replaceTb.Text = opt.Replacement.replace;
            replaceWithTb.Text = opt.Replacement.with;
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
