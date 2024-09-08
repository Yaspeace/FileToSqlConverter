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
            exportBtn = new Button();
            openFileDialog = new OpenFileDialog();
            fieldsTree = new TreeView();
            upBtn = new Button();
            downBtn = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            импортToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            csvToolStripMenuItem = new ToolStripMenuItem();
            manualToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            средстваToolStripMenuItem = new ToolStripMenuItem();
            guidToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            fileNameLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 38);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Текущий файл:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 406);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Пример";
            // 
            // exampleLbl
            // 
            exampleLbl.BorderStyle = BorderStyle.FixedSingle;
            exampleLbl.Font = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            exampleLbl.Location = new Point(13, 426);
            exampleLbl.Name = "exampleLbl";
            exampleLbl.Size = new Size(887, 113);
            exampleLbl.TabIndex = 4;
            exampleLbl.Text = "(),";
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(779, 543);
            exportBtn.Margin = new Padding(3, 4, 3, 4);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(121, 51);
            exportBtn.TabIndex = 6;
            exportBtn.Text = "Выгрузить...";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
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
            fieldsTree.Location = new Point(12, 99);
            fieldsTree.Margin = new Padding(3, 4, 3, 4);
            fieldsTree.Name = "fieldsTree";
            treeNode1.Name = "rootNode";
            treeNode1.Text = "Все поля";
            fieldsTree.Nodes.AddRange(new TreeNode[] { treeNode1 });
            fieldsTree.Size = new Size(465, 303);
            fieldsTree.TabIndex = 13;
            fieldsTree.ItemDrag += fieldsTree_ItemDrag;
            fieldsTree.NodeMouseDoubleClick += fieldsTree_NodeMouseDoubleClick;
            fieldsTree.DragDrop += fieldsTree_DragDrop;
            fieldsTree.DragEnter += fieldsTree_DragEnter;
            // 
            // upBtn
            // 
            upBtn.Location = new Point(485, 99);
            upBtn.Margin = new Padding(3, 4, 3, 4);
            upBtn.Name = "upBtn";
            upBtn.Size = new Size(86, 31);
            upBtn.TabIndex = 14;
            upBtn.Text = "/\\";
            upBtn.UseVisualStyleBackColor = true;
            upBtn.Click += upBtn_Click;
            // 
            // downBtn
            // 
            downBtn.Location = new Point(485, 138);
            downBtn.Margin = new Padding(3, 4, 3, 4);
            downBtn.Name = "downBtn";
            downBtn.Size = new Size(86, 31);
            downBtn.TabIndex = 15;
            downBtn.Text = "\\/";
            downBtn.UseVisualStyleBackColor = true;
            downBtn.Click += downBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(483, 177);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(86, 31);
            deleteBtn.TabIndex = 16;
            deleteBtn.Text = "X";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(483, 216);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(86, 31);
            addBtn.TabIndex = 17;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, средстваToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 28);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { импортToolStripMenuItem, resetToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // импортToolStripMenuItem
            // 
            импортToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excelToolStripMenuItem, csvToolStripMenuItem, manualToolStripMenuItem });
            импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            импортToolStripMenuItem.Size = new Size(147, 26);
            импортToolStripMenuItem.Text = "Импорт";
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(188, 26);
            excelToolStripMenuItem.Text = "Excel...";
            excelToolStripMenuItem.Click += ImportExcel;
            // 
            // csvToolStripMenuItem
            // 
            csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            csvToolStripMenuItem.Size = new Size(188, 26);
            csvToolStripMenuItem.Text = "CSV...";
            csvToolStripMenuItem.Click += ImportCsv;
            // 
            // manualToolStripMenuItem
            // 
            manualToolStripMenuItem.Enabled = false;
            manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            manualToolStripMenuItem.Size = new Size(188, 26);
            manualToolStripMenuItem.Text = "Ручной ввод...";
            manualToolStripMenuItem.ToolTipText = "В разработке...";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(147, 26);
            resetToolStripMenuItem.Text = "Сброс";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // средстваToolStripMenuItem
            // 
            средстваToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guidToolStripMenuItem });
            средстваToolStripMenuItem.Name = "средстваToolStripMenuItem";
            средстваToolStripMenuItem.Size = new Size(86, 24);
            средстваToolStripMenuItem.Text = "Средства";
            // 
            // guidToolStripMenuItem
            // 
            guidToolStripMenuItem.CheckOnClick = true;
            guidToolStripMenuItem.Name = "guidToolStripMenuItem";
            guidToolStripMenuItem.Size = new Size(198, 26);
            guidToolStripMenuItem.Text = "Столбец ГУИов";
            guidToolStripMenuItem.Click += guidToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(187, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // fileNameLbl
            // 
            fileNameLbl.AutoEllipsis = true;
            fileNameLbl.BackColor = SystemColors.InactiveBorder;
            fileNameLbl.BorderStyle = BorderStyle.FixedSingle;
            fileNameLbl.Location = new Point(130, 38);
            fileNameLbl.Name = "fileNameLbl";
            fileNameLbl.Size = new Size(770, 25);
            fileNameLbl.TabIndex = 20;
            fileNameLbl.Text = "Ничего не импортировано :'-(";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 602);
            Controls.Add(fileNameLbl);
            Controls.Add(addBtn);
            Controls.Add(deleteBtn);
            Controls.Add(downBtn);
            Controls.Add(upBtn);
            Controls.Add(fieldsTree);
            Controls.Add(exportBtn);
            Controls.Add(exampleLbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Files to SQL converter";
            FormClosed += Form1_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label exampleLbl;
        private Button exportBtn;
        private OpenFileDialog openFileDialog;
        private TreeView fieldsTree;
        private Button upBtn;
        private Button downBtn;
        private Button deleteBtn;
        private Button addBtn;
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
    }
}