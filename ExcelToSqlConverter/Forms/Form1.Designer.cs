﻿namespace ExcelToSqlConverter.Forms
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
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 27);
            label1.TabIndex = 1;
            label1.Text = "Текущий файл:";
            // 
            // label2
            // 
            tableLayoutPanel1.SetColumnSpan(label2, 3);
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 443);
            label2.Name = "label2";
            label2.Size = new Size(1091, 20);
            label2.TabIndex = 3;
            label2.Text = "Пример";
            // 
            // exampleLbl
            // 
            exampleLbl.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(exampleLbl, 3);
            exampleLbl.Dock = DockStyle.Fill;
            exampleLbl.Font = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            exampleLbl.Location = new Point(3, 463);
            exampleLbl.Name = "exampleLbl";
            exampleLbl.Size = new Size(1091, 192);
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
            fieldsTree.Location = new Point(3, 31);
            fieldsTree.Margin = new Padding(3, 4, 3, 4);
            fieldsTree.Name = "fieldsTree";
            treeNode1.Name = "rootNode";
            treeNode1.Text = "Все поля";
            fieldsTree.Nodes.AddRange(new TreeNode[] { treeNode1 });
            fieldsTree.Size = new Size(617, 347);
            fieldsTree.TabIndex = 13;
            fieldsTree.ItemDrag += fieldsTree_ItemDrag;
            fieldsTree.NodeMouseDoubleClick += fieldsTree_NodeMouseDoubleClick;
            fieldsTree.DragDrop += fieldsTree_DragDrop;
            fieldsTree.DragEnter += fieldsTree_DragEnter;
            // 
            // upBtn
            // 
            upBtn.Location = new Point(3, 4);
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
            downBtn.Location = new Point(3, 43);
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
            deleteBtn.Location = new Point(3, 121);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(86, 31);
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
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1097, 30);
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
            импортToolStripMenuItem.Size = new Size(224, 26);
            импортToolStripMenuItem.Text = "Импорт";
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(224, 26);
            excelToolStripMenuItem.Text = "Excel...";
            excelToolStripMenuItem.Click += ImportExcel;
            // 
            // csvToolStripMenuItem
            // 
            csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            csvToolStripMenuItem.Size = new Size(224, 26);
            csvToolStripMenuItem.Text = "CSV...";
            csvToolStripMenuItem.Click += ImportCsv;
            // 
            // manualToolStripMenuItem
            // 
            manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            manualToolStripMenuItem.Size = new Size(224, 26);
            manualToolStripMenuItem.Text = "Ручной ввод...";
            manualToolStripMenuItem.Click += manualToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(224, 26);
            resetToolStripMenuItem.Text = "Сброс";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyMenuItem, guidMenuItem, unionMenuItem });
            addToolStripMenuItem.Enabled = false;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(90, 24);
            addToolStripMenuItem.Text = "Добавить";
            // 
            // copyMenuItem
            // 
            copyMenuItem.Name = "copyMenuItem";
            copyMenuItem.Size = new Size(346, 26);
            copyMenuItem.Text = "Скопировать выделенный столбец";
            copyMenuItem.Click += copyMenuItem_Click;
            // 
            // guidMenuItem
            // 
            guidMenuItem.Name = "guidMenuItem";
            guidMenuItem.Size = new Size(346, 26);
            guidMenuItem.Text = "Столбец ГУИДов";
            guidMenuItem.Click += guidMenuItem_Click;
            // 
            // unionMenuItem
            // 
            unionMenuItem.Name = "unionMenuItem";
            unionMenuItem.Size = new Size(346, 26);
            unionMenuItem.Text = "Объединение/вычислимый столбец";
            unionMenuItem.Click += unionMenuItem_Click;
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
            tableLayoutPanel1.SetColumnSpan(fileNameLbl, 2);
            fileNameLbl.Location = new Point(153, 0);
            fileNameLbl.Name = "fileNameLbl";
            fileNameLbl.Size = new Size(941, 27);
            fileNameLbl.TabIndex = 20;
            fileNameLbl.Text = "Ничего не импортировано :'-(";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
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
            tableLayoutPanel1.Location = new Point(0, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(1097, 655);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Controls.Add(upBtn);
            panel1.Controls.Add(downBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(626, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 349);
            panel1.TabIndex = 21;
            // 
            // exportBtn
            // 
            exportBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exportBtn.Enabled = false;
            exportBtn.Location = new Point(499, 386);
            exportBtn.Margin = new Padding(3, 4, 3, 4);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(121, 53);
            exportBtn.TabIndex = 6;
            exportBtn.Text = "Выгрузить...";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 685);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(740, 451);
            Name = "Form1";
            Text = "Files to SQL converter";
            FormClosed += Form1_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
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