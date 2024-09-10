using System.IO.Packaging;
using ExcelToSqlConverter.Controllers;
using ExcelToSqlConverter.Enums;
using ExcelToSqlConverter.Extensions;
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

            var imported = _controller.ImportCsv(form.FileName, form.Splitter, form.HeadersLine);
            SetImported(imported);

            if (imported)
                fileNameLbl.Text = form.FileName;
            else
                ShowError("Не удалось импортировать указанный файл");

            RefreshView();
        }

        private void ImportExcel(object sender, EventArgs e)
        {
            var form = new ExcelImportForm(openFileDialog);
            if (form.ShowDialog() != DialogResult.OK) return;

            Reset();

            var imported = form.DefaultList
                ? _controller.ImportExcelDefault(form.FileName, form.HeadersLine)
                : _controller.ImportExcel(form.FileName, form.ListName, form.HeadersLine);
            SetImported(imported);

            if (imported)
                fileNameLbl.Text = form.FileName;
            else
                ShowError("Не удалось импортировать указанный файл");

            RefreshView();
        }

        private void RedrawExample()
        {
            exampleLbl.Text = _controller.GetExampleString();
            exampleLbl.FitFontSize(20f);
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

            if (e?.Data?.GetData(typeof(TreeNode)) is not TreeNode draggedNode ||
                draggedNode is null ||
                draggedNode.Equals(targetNode) ||
                draggedNode.Tag is not IFieldOptions field)
            {
                return;
            }

            var target = targetNode?.Tag as IFieldOptions;

            if (target is null || target.Type == OptionsTypeEnum.Field)
            {
                if (draggedNode.Parent is null || draggedNode.Parent.Equals(FieldsTreeRoot))
                {
                    return;
                }

                if (draggedNode.Parent.Tag is IFieldOptions parent)
                {
                    _controller.ReplaceFieldFrom(field, parent);
                    RefreshView();
                }
            }
            else if (target.Type == OptionsTypeEnum.Union)
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
            _controller.AddUnion();
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
                union.SetFromProperties(form);
            }
            else if (e.Node.Tag is FieldOptions field && field != null)
            {
                var form = new FieldPropertiesForm(field);
                if (form.ShowDialog() != DialogResult.OK) return;
                field.SetFromProperties(form);
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

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            RefreshView();
        }

        private void SetImported(bool imported)
        {
            exportBtn.Enabled = imported;
            addToolStripMenuItem.Enabled = imported;
        }

        private void Reset()
        {
            _controller.Reset();
            SetImported(false);
            fileNameLbl.Text = UIStrings.NothingImported;
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            if (fieldsTree.SelectedNode?.Tag is IFieldOptions field && field != null)
            {
                _controller.CopyField(field);
                RefreshView();
            }
        }

        private void guidMenuItem_Click(object sender, EventArgs e)
        {
            _controller.AddGuidField();
            RefreshView();
        }

        private void unionMenuItem_Click(object sender, EventArgs e)
        {
            _controller.AddUnion();
            RefreshView();
        }

        private void RefreshView()
        {
            SetTree();
            RedrawExample();
        }

        private static void ShowError(string message)
            => MessageBox.Show(message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}