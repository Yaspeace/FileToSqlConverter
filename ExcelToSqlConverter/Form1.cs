using ExcelToSqlConverter.Controllers;
using ExcelToSqlConverter.Models;

namespace ExcelToSqlConverter
{
    public partial class Form1 : Form
    {
        private readonly MainController _controller;

        private TreeNode FieldsTreeRoot => fieldsTree.Nodes[0]; 

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

            if (form.DefaultList)
                _controller.ImportExcelDefault(fileNameTb.Text, form.HeadersLine);
            else
                _controller.ImportExcel(fileNameTb.Text, form.ListName, form.HeadersLine);

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

        private void SetTree(int selectedIndex = -1)
        {
            fieldsTree.Nodes[0].Nodes.Clear();

            foreach (var field in _controller.Fields)
            {
                var node = new TreeNode()
                {
                    Text = field.Header,
                    Tag = field
                };

                if (field.Type == OptionsTypeEnum.Union)
                {
                    node.BackColor = Color.WhiteSmoke;
                    foreach (var sub in field.Fields)
                    {
                        var subnode = new TreeNode()
                        {
                            Text = sub.Header,
                            Tag = sub
                        };

                        node.Nodes.Add(subnode);
                    }
                }
                
                fieldsTree.Nodes[0].Nodes.Add(node);
            }

            if (selectedIndex >= 0 && FieldsTreeRoot.Nodes.Count > 0)
            {
                selectedIndex = Math.Min(selectedIndex, FieldsTreeRoot.Nodes.Count - 1);
                fieldsTree.SelectedNode = FieldsTreeRoot.Nodes[selectedIndex];
            }

            fieldsTree.Select();
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
            var targetPoint = fieldsTree.PointToClient(new Point(e.X, e.Y));
            var targetNode = fieldsTree.GetNodeAt(targetPoint);

            if (
                targetNode != null &&
                e?.Data?.GetData(typeof(TreeNode)) is TreeNode draggedNode && draggedNode != null &&
                !draggedNode.Equals(targetNode) &&
                draggedNode.Tag is IFieldOptions field && field != null &&
                targetNode.Tag is IFieldOptions target && target != null)
            {
                _controller.ReplaceFieldTo(field, target);
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
            if (fieldsTree.SelectedNode.Tag is IFieldOptions fieldOpts && fieldOpts != null)
            {
                var fieldIdx = fieldsTree.SelectedNode.Index;
                _controller.Remove(fieldOpts);
                SetTree(fieldIdx);
                RedrawExample();
            }
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
            if (e.Node.Tag is Union union && union != null)
            {
                var form = new UnionForm(union);
                if (form.ShowDialog() != DialogResult.OK) return;
                _controller.SetUnionProperties(e.Node.Tag, form.Header, form.Quotes, form.Splitter);
            }
            else if (e.Node.Tag is IFieldOptions field && field != null)
            {
                var form = new FieldPropertiesForm(field);
                if (form.ShowDialog() != DialogResult.OK) return;
                _controller.SetFieldProperties(e.Node.Tag, form.Header, form.Quotes);
            }

            SetTree();
            RedrawExample();
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            if (fieldsTree.SelectedNode.Tag is IFieldOptions field && field != null)
            {
                _controller.Move(field, true);
                SetTree();
                RedrawExample();
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            if (fieldsTree.SelectedNode.Tag is IFieldOptions field && field != null)
            {
                _controller.Move(field, false);
                SetTree();
                RedrawExample();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.Dispose();
        }
    }
}