namespace ExcelToSqlConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            Label label2;
            TreeNode treeNode1 = new TreeNode("Все поля");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            exampleLbl = new Label();
            openFileDialog = new OpenFileDialog();
            fieldsTree = new TreeView();
            upBtn = new Button();
            downBtn = new Button();
            deleteBtn = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            импортToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            csvToolStripMenuItem = new ToolStripMenuItem();
            manualToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            copyMenuItem = new ToolStripMenuItem();
            guidMenuItem = new ToolStripMenuItem();
            unionMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            fileNameLbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            exportBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Текущий файл:";
            // 
            // label2
            // 
            tableLayoutPanel1.SetColumnSpan(label2, 3);
            label2.Location = new Point(3, 331);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Пример";
            // 
            // exampleLbl
            // 
            exampleLbl.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(exampleLbl, 3);
            exampleLbl.Dock = DockStyle.Fill;
            exampleLbl.Font = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            exampleLbl.Location = new Point(3, 346);
            exampleLbl.Name = "exampleLbl";
            exampleLbl.Size = new Size(954, 144);
            exampleLbl.TabIndex = 4;
            exampleLbl.Text = "(),";
            // 
            // openFileDialog
            // 
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = false;
            openFileDialog.DefaultExt = "sql";
            // 
            // fieldsTree
            // 
            fieldsTree.AllowDrop = true;
            tableLayoutPanel1.SetColumnSpan(fieldsTree, 2);
            fieldsTree.Dock = DockStyle.Fill;
            fieldsTree.Location = new Point(3, 22);
            fieldsTree.Name = "fieldsTree";
            treeNode1.Name = "rootNode";
            treeNode1.Text = "Все поля";
            fieldsTree.Nodes.AddRange(new TreeNode[] { treeNode1 });
            fieldsTree.Size = new Size(524, 260);
            fieldsTree.TabIndex = 13;
            fieldsTree.ItemDrag += fieldsTree_ItemDrag;
            fieldsTree.NodeMouseDoubleClick += fieldsTree_NodeMouseDoubleClick;
            fieldsTree.DragDrop += fieldsTree_DragDrop;
            fieldsTree.DragEnter += fieldsTree_DragEnter;
            // 
            // upBtn
            // 
            upBtn.Location = new Point(3, 3);
            upBtn.Name = "upBtn";
            upBtn.Size = new Size(75, 23);
            upBtn.TabIndex = 14;
            upBtn.Text = "/\\";
            upBtn.UseVisualStyleBackColor = true;
            upBtn.Click += upBtn_Click;
            // 
            // downBtn
            // 
            downBtn.Location = new Point(3, 32);
            downBtn.Name = "downBtn";
            downBtn.Size = new Size(75, 23);
            downBtn.TabIndex = 15;
            downBtn.Text = "\\/";
            downBtn.UseVisualStyleBackColor = true;
            downBtn.Click += downBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(3, 91);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 16;
            deleteBtn.Text = "X";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, addToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(960, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { импортToolStripMenuItem, resetToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // импортToolStripMenuItem
            // 
            импортToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excelToolStripMenuItem, csvToolStripMenuItem, manualToolStripMenuItem });
            импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            импортToolStripMenuItem.Size = new Size(118, 22);
            импортToolStripMenuItem.Text = "Импорт";
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(152, 22);
            excelToolStripMenuItem.Text = "Excel...";
            excelToolStripMenuItem.Click += ImportExcel;
            // 
            // csvToolStripMenuItem
            // 
            csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            csvToolStripMenuItem.Size = new Size(152, 22);
            csvToolStripMenuItem.Text = "CSV...";
            csvToolStripMenuItem.Click += ImportCsv;
            // 
            // manualToolStripMenuItem
            // 
            manualToolStripMenuItem.Enabled = false;
            manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            manualToolStripMenuItem.Size = new Size(152, 22);
            manualToolStripMenuItem.Text = "Ручной ввод...";
            manualToolStripMenuItem.ToolTipText = "В разработке...";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(118, 22);
            resetToolStripMenuItem.Text = "Сброс";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyMenuItem, guidMenuItem, unionMenuItem });
            addToolStripMenuItem.Enabled = false;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(71, 20);
            addToolStripMenuItem.Text = "Добавить";
            // 
            // copyMenuItem
            // 
            copyMenuItem.Name = "copyMenuItem";
            copyMenuItem.Size = new Size(276, 22);
            copyMenuItem.Text = "Скопировать выделенный столбец";
            copyMenuItem.Click += copyMenuItem_Click;
            // 
            // guidMenuItem
            // 
            guidMenuItem.Name = "guidMenuItem";
            guidMenuItem.Size = new Size(276, 22);
            guidMenuItem.Text = "Столбец ГУИДов";
            guidMenuItem.Click += guidMenuItem_Click;
            // 
            // unionMenuItem
            // 
            unionMenuItem.Name = "unionMenuItem";
            unionMenuItem.Size = new Size(276, 22);
            unionMenuItem.Text = "Объединение/вычислимый столбец";
            unionMenuItem.Click += unionMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // fileNameLbl
            // 
            fileNameLbl.AutoEllipsis = true;
            fileNameLbl.BackColor = SystemColors.InactiveBorder;
            fileNameLbl.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(fileNameLbl, 2);
            fileNameLbl.Dock = DockStyle.Fill;
            fileNameLbl.Location = new Point(103, 0);
            fileNameLbl.Name = "fileNameLbl";
            fileNameLbl.Size = new Size(854, 19);
            fileNameLbl.TabIndex = 20;
            fileNameLbl.Text = "Ничего не импортировано :'-(";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(exampleLbl, 0, 4);
            tableLayoutPanel1.Controls.Add(fileNameLbl, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 2, 1);
            tableLayoutPanel1.Controls.Add(fieldsTree, 0, 1);
            tableLayoutPanel1.Controls.Add(exportBtn, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(960, 490);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Controls.Add(upBtn);
            panel1.Controls.Add(downBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(533, 21);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 262);
            panel1.TabIndex = 21;
            // 
            // exportBtn
            // 
            exportBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exportBtn.Enabled = false;
            exportBtn.Location = new Point(421, 288);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(106, 40);
            exportBtn.TabIndex = 6;
            exportBtn.Text = "Выгрузить...";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 514);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(650, 350);
            Name = "Form1";
            Text = "Files to SQL converter";
            FormClosed += Form1_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label exampleLbl;
        private OpenFileDialog openFileDialog;
        private TreeView fieldsTree;
        private Button upBtn;
        private Button downBtn;
        private Button deleteBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem импортToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
        private ToolStripMenuItem csvToolStripMenuItem;
        private ToolStripMenuItem manualToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem средстваToolStripMenuItem;
        private ToolStripMenuItem guidToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Label fileNameLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button exportBtn;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem copyMenuItem;
        private ToolStripMenuItem guidMenuItem;
        private ToolStripMenuItem unionMenuItem;
    }
}