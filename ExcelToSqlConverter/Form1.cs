using ExcelToSqlConverter.Controllers;
using ExcelToSqlConverter.Models;

namespace ExcelToSqlConverter
{
    public partial class Form1 : Form
    {
        private readonly MainController _controller;

        public Form1()
        {
            InitializeComponent();
            _controller = new MainController();
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameTb.Text = openFileDialog.FileName;
            }
        }

        private void parseBtn_Click(object sender, EventArgs e)
        {
            var form = new CsvImportForm();
            if (form.ShowDialog() != DialogResult.OK) return;

            _controller.ImportCsv(fileNameTb.Text, form.Splitter, form.HeadersLine);
            _controller.SetGuidField(guidsCb.Checked);

            SetTree();
            RedrawExample();
        }

        private void importExcelBtn_Click(object sender, EventArgs e)
        {
            var form = new ExcelImportForm();
            if (form.ShowDialog() != DialogResult.OK) return;

            if (form.DefaultList) _controller.ImportExcelDefault(fileNameTb.Text, form.HeadersLine);
            else _controller.ImportExcel(fileNameTb.Text, form.ListName, form.HeadersLine);
            _controller.SetGuidField(guidsCb.Checked);

            SetTree();
            RedrawExample();
        }

        private void RedrawExample()
        {
            exampleLbl.Text = _controller.GetExampleString();

            float maxSize = 20.0f;
            exampleLbl.Font = new Font(exampleLbl.Font.FontFamily, maxSize, exampleLbl.Font.Style);
            var mult = (exampleLbl.Height / exampleLbl.Font.Height) + 1;
            while (exampleLbl.Width * mult < TextRenderer.MeasureText(exampleLbl.Text,
             new Font(exampleLbl.Font.FontFamily, exampleLbl.Font.Size, exampleLbl.Font.Style)).Width)
            {
                exampleLbl.Font = new Font(exampleLbl.Font.FontFamily, exampleLbl.Font.Size - 0.5f, exampleLbl.Font.Style);
                mult = (exampleLbl.Height / exampleLbl.Font.Height) + 1;
            }
        }

        private void SetTree()
        {
            fieldsTree.Nodes[0].Nodes.Clear();

            foreach (var field in _controller.Fields)
            {
                var node = new TreeNode();
                node.Text = field.Header;
                node.Tag = field;
                if (field.Type == OptionsTypeEnum.Union)
                {
                    foreach (var sub in field.Fields)
                    {
                        var subnode = new TreeNode();
                        subnode.Text = sub.Header;
                        subnode.Tag = sub;
                        node.Nodes.Add(subnode);
                    }
                }
                
                fieldsTree.Nodes[0].Nodes.Add(node);
            }
            fieldsTree.Refresh();
        }

        private void guidsCb_CheckedChanged(object sender, EventArgs e)
        {
            _controller.SetGuidField(guidsCb.Checked);
            SetTree();
            RedrawExample();
        }

        private void fieldsTree_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = fieldsTree.PointToClient(new Point(e.X, e.Y));

            TreeNode targetNode = fieldsTree.GetNodeAt(targetPoint);

            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            if (!draggedNode.Equals(targetNode) && targetNode != null)
            {
                _controller.PlaceTo(draggedNode.Tag, targetNode.Tag);
                SetTree();
                RedrawExample();
            }
        }

        private void fieldsTree_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void fieldsTree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _controller.AddUnion("TestHeader", " ");
            SetTree();
            RedrawExample();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            _controller.Remove(fieldsTree.SelectedNode.Tag);
            SetTree();
            RedrawExample();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _controller.ExportFile(openFileDialog.FileName);
                MessageBox.Show("Успешно!");
            }
        }

        private void fieldsTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is IFieldOptions)
            {
                var form = new FieldPropertiesForm(e.Node.Tag as IFieldOptions);
                if (form.ShowDialog() != DialogResult.OK) return;
                _controller.SetFieldProperties(e.Node.Tag, form.Header, form.Quotes);
            }
            if (e.Node.Tag is Union)
            {
                var form = new UnionForm(e.Node.Tag as Union);
                if (form.ShowDialog() != DialogResult.OK) return;
                _controller.SetUnionProperties(e.Node.Tag, form.Header, form.Quotes, form.Splitter);
            }
            SetTree();
            RedrawExample();
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            _controller.Move(fieldsTree.SelectedNode.Tag, true);
            SetTree();
            RedrawExample();
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            _controller.Move(fieldsTree.SelectedNode.Tag, false);
            SetTree();
            RedrawExample();
        }
    }
}