using ExcelToSqlConverter.Controllers;
using ExcelToSqlConverter.Models.Fields;

namespace ExcelToSqlConverter
{
    public partial class Form1 : Form
    {
        private readonly MainController _controller;

        private TreeNode FieldsTreeRoot
            => fieldsTree.Nodes[0];

        public Form1()
        {
            InitializeComponent();
            _controller = new MainController();
        }

        private void ImportCsv(object sender, EventArgs e)
        {
            var form = new CsvImportForm(openFileDialog);
            if (form.ShowDialog() != DialogResult.OK) return;

            Reset();
            _controller.ImportCsv(form.FileName, form.Splitter, form.HeadersLine);
            fileNameLbl.Text = form.FileName;
            RefreshView();
        }

        private void ImportExcel(object sender, EventArgs e)
        {
            var form = new ExcelImportForm(openFileDialog);
            if (form.ShowDialog() != DialogResult.OK) return;

            Reset();
            if (form.DefaultList)
                _controller.ImportExcelDefault(form.FileName, form.HeadersLine);
            else
                _controller.ImportExcel(form.FileName, form.ListName, form.HeadersLine);
            fileNameLbl.Text = form.FileName;
            RefreshView();
        }

        private void RedrawExample()
        {
            exampleLbl.Text = _controller.GetExampleString();
            if (string.IsNullOrEmpty(exampleLbl.Text)) return;

            var maxSize = 20.0f;
            exampleLbl.Font = new(exampleLbl.Font.FontFamily, maxSize, exampleLbl.Font.Style);
            var mult = (exampleLbl.Height / exampleLbl.Font.Height) + 1;
            while (exampleLbl.Width * mult < TextRenderer.MeasureText(exampleLbl.Text, exampleLbl.Font).Width)
            {
                exampleLbl.Font = new(exampleLbl.Font.FontFamily, exampleLbl.Font.Size - 0.5f, exampleLbl.Font.Style);
                mult = (exampleLbl.Height / exampleLbl.Font.Height) + 1;
            }
        }

        private void SetTree()
        {
            fieldsTree.Nodes[0].Nodes.Clear();

            foreach (var field in _controller.Fields)
            {
                var node = new TreeNode()
                {
                    Text = field.Header,
                    Tag = field,
                    Name = field.Header
                };

                if (field.Type == OptionsTypeEnum.Union)
                {
                    node.BackColor = Color.WhiteSmoke;
                    foreach (var sub in field.Fields)
                    {
                        var subnode = new TreeNode()
                        {
                            Text = sub.Header,
                            Tag = sub,
                            Name = sub.Header
                        };

                        node.Nodes.Add(subnode);
                    }
                }

                fieldsTree.Nodes[0].Nodes.Add(node);
            }

            fieldsTree.Refresh();
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
                RefreshView();
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
            RefreshView();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (fieldsTree.SelectedNode.Tag is IFieldOptions fieldOpts && fieldOpts != null)
            {
                var fieldIdx = fieldsTree.SelectedNode.Index;
                _controller.Remove(fieldOpts);

                SetTree();
                SelectNode(fieldIdx);
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

            RefreshView();
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            if (fieldsTree.SelectedNode.Tag is IFieldOptions field && field != null)
            {
                var key = fieldsTree.SelectedNode.Name;

                _controller.Move(field, true);

                SetTree();
                SelectNode(key);
                RedrawExample();
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            if (fieldsTree.SelectedNode.Tag is IFieldOptions field && field != null)
            {
                var key = fieldsTree.SelectedNode.Name;

                _controller.Move(field, false);

                SetTree();
                SelectNode(key);
                RedrawExample();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.Dispose();
        }

        private void SelectNode(int index)
        {
            if (index >= 0 && FieldsTreeRoot.Nodes.Count > 0)
            {
                index = Math.Min(index, FieldsTreeRoot.Nodes.Count - 1);
                SelectNode(FieldsTreeRoot.Nodes[index]);
            }
        }

        private void SelectNode(string key)
            => SelectNode(GetNodeByKey(key));

        private void SelectNode(TreeNode node)
        {
            fieldsTree.SelectedNode = node;
            fieldsTree.Select();
            fieldsTree.Refresh();
        }

        private TreeNode GetNodeByKey(string key)
            => fieldsTree.Nodes.Find(key, true)[0];

        private void guidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is not ToolStripMenuItem item) return;

            _controller.SetGuidField(item.Checked);
            RefreshView();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            RefreshView();
        }

        private void Reset()
        {
            _controller.Reset();
            guidToolStripMenuItem.Checked = false;
            fileNameLbl.Text = string.Empty;
        }

        private void RefreshView()
        {
            SetTree();
            RedrawExample();
        }
    }
}