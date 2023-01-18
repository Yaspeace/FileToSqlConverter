using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToSqlConverter
{
    public partial class CsvImportForm : Form
    {
        public char Splitter
        {
            get
            {
                if (customSplitterCb.Checked) return customSplitterTb.Text[0];
                else return splitters.First(x => x.name == splitterCb.Text).ch;
            }
        }

        public bool HeadersLine => headersLineCb.Checked;

        readonly (string name, char ch)[] splitters = new (string, char)[]
        {
            ("Запятая", ','),
            ("Точка", '.'),
            ("Табуляция", '\t'),
            ("Пробел", ' '),
            ("Доллар", '$'),
            ("Двоеточие", ':'),
            ("Точка с запятой", ';')
        };

        public CsvImportForm()
        {
            InitializeComponent();
            splitterCb.Items.AddRange(splitters.Select(x => x.name).ToArray());
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
    }
}
