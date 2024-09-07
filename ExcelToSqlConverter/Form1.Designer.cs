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
            fileNameTb = new TextBox();
            chooseFileBtn = new Button();
            exampleLbl = new Label();
            exportBtn = new Button();
            openFileDialog = new OpenFileDialog();
            guidsCb = new CheckBox();
            eraseBtn = new Button();
            importCsvBtn = new Button();
            fieldsTree = new TreeView();
            upBtn = new Button();
            downBtn = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            importExcelBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Файл:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 297);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Пример";
            // 
            // fileNameTb
            // 
            fileNameTb.Location = new Point(57, 12);
            fileNameTb.Name = "fileNameTb";
            fileNameTb.Size = new Size(185, 23);
            fileNameTb.TabIndex = 0;
            // 
            // chooseFileBtn
            // 
            chooseFileBtn.Location = new Point(241, 12);
            chooseFileBtn.Name = "chooseFileBtn";
            chooseFileBtn.Size = new Size(30, 23);
            chooseFileBtn.TabIndex = 2;
            chooseFileBtn.Text = "...";
            chooseFileBtn.UseVisualStyleBackColor = true;
            chooseFileBtn.Click += chooseFileBtn_Click;
            // 
            // exampleLbl
            // 
            exampleLbl.BorderStyle = BorderStyle.FixedSingle;
            exampleLbl.Font = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            exampleLbl.Location = new Point(12, 312);
            exampleLbl.Name = "exampleLbl";
            exampleLbl.Size = new Size(776, 85);
            exampleLbl.TabIndex = 4;
            exampleLbl.Text = "(),";
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(682, 400);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(106, 38);
            exportBtn.TabIndex = 6;
            exportBtn.Text = "Выгрузить...";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // guidsCb
            // 
            guidsCb.AutoSize = true;
            guidsCb.Location = new Point(12, 41);
            guidsCb.Name = "guidsCb";
            guidsCb.Size = new Size(172, 19);
            guidsCb.TabIndex = 8;
            guidsCb.Text = "Добавить столбец ГУИДов";
            guidsCb.UseVisualStyleBackColor = true;
            guidsCb.CheckedChanged += guidsCb_CheckedChanged;
            // 
            // eraseBtn
            // 
            eraseBtn.Location = new Point(713, 11);
            eraseBtn.Name = "eraseBtn";
            eraseBtn.Size = new Size(75, 23);
            eraseBtn.TabIndex = 9;
            eraseBtn.Text = "Сброс";
            eraseBtn.UseVisualStyleBackColor = true;
            eraseBtn.Click += eraseBtn_Click;
            // 
            // importCsvBtn
            // 
            importCsvBtn.Location = new Point(277, 11);
            importCsvBtn.Name = "importCsvBtn";
            importCsvBtn.Size = new Size(101, 23);
            importCsvBtn.TabIndex = 12;
            importCsvBtn.Text = "Импорт CSV";
            importCsvBtn.UseVisualStyleBackColor = true;
            importCsvBtn.Click += parseBtn_Click;
            // 
            // fieldsTree
            // 
            fieldsTree.AllowDrop = true;
            fieldsTree.Location = new Point(12, 66);
            fieldsTree.Name = "fieldsTree";
            treeNode1.Name = "rootNode";
            treeNode1.Text = "Все поля";
            fieldsTree.Nodes.AddRange(new TreeNode[] { treeNode1 });
            fieldsTree.Size = new Size(407, 228);
            fieldsTree.TabIndex = 13;
            fieldsTree.ItemDrag += fieldsTree_ItemDrag;
            fieldsTree.NodeMouseDoubleClick += fieldsTree_NodeMouseDoubleClick;
            fieldsTree.DragDrop += fieldsTree_DragDrop;
            fieldsTree.DragEnter += fieldsTree_DragEnter;
            // 
            // upBtn
            // 
            upBtn.Location = new Point(425, 66);
            upBtn.Name = "upBtn";
            upBtn.Size = new Size(75, 23);
            upBtn.TabIndex = 14;
            upBtn.Text = "/\\";
            upBtn.UseVisualStyleBackColor = true;
            upBtn.Click += upBtn_Click;
            // 
            // downBtn
            // 
            downBtn.Location = new Point(425, 95);
            downBtn.Name = "downBtn";
            downBtn.Size = new Size(75, 23);
            downBtn.TabIndex = 15;
            downBtn.Text = "\\/";
            downBtn.UseVisualStyleBackColor = true;
            downBtn.Click += downBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(425, 124);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 16;
            deleteBtn.Text = "X";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(425, 153);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 17;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // importExcelBtn
            // 
            importExcelBtn.Location = new Point(384, 11);
            importExcelBtn.Name = "importExcelBtn";
            importExcelBtn.Size = new Size(101, 23);
            importExcelBtn.TabIndex = 18;
            importExcelBtn.Text = "Импорт Excel";
            importExcelBtn.UseVisualStyleBackColor = true;
            importExcelBtn.Click += importExcelBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(importExcelBtn);
            Controls.Add(addBtn);
            Controls.Add(deleteBtn);
            Controls.Add(downBtn);
            Controls.Add(upBtn);
            Controls.Add(fieldsTree);
            Controls.Add(importCsvBtn);
            Controls.Add(eraseBtn);
            Controls.Add(guidsCb);
            Controls.Add(exportBtn);
            Controls.Add(exampleLbl);
            Controls.Add(label2);
            Controls.Add(chooseFileBtn);
            Controls.Add(label1);
            Controls.Add(fileNameTb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Files to SQL converter";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fileNameTb;
        private Button chooseFileBtn;
        private Label exampleLbl;
        private Button exportBtn;
        private OpenFileDialog openFileDialog;
        private CheckBox guidsCb;
        private Button eraseBtn;
        private Button importCsvBtn;
        private TreeView fieldsTree;
        private Button upBtn;
        private Button downBtn;
        private Button deleteBtn;
        private Button addBtn;
        private Button importExcelBtn;
    }
}