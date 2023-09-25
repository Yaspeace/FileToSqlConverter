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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Все поля");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileNameTb = new System.Windows.Forms.TextBox();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.exampleLbl = new System.Windows.Forms.Label();
            this.exportBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.guidsCb = new System.Windows.Forms.CheckBox();
            this.eraseBtn = new System.Windows.Forms.Button();
            this.importCsvBtn = new System.Windows.Forms.Button();
            this.fieldsTree = new System.Windows.Forms.TreeView();
            this.upBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.importExcelBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Файл:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 297);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Пример";
            // 
            // fileNameTb
            // 
            this.fileNameTb.Location = new System.Drawing.Point(57, 12);
            this.fileNameTb.Name = "fileNameTb";
            this.fileNameTb.Size = new System.Drawing.Size(185, 23);
            this.fileNameTb.TabIndex = 0;
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Location = new System.Drawing.Point(241, 12);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(30, 23);
            this.chooseFileBtn.TabIndex = 2;
            this.chooseFileBtn.Text = "...";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.chooseFileBtn_Click);
            // 
            // exampleLbl
            // 
            this.exampleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exampleLbl.Font = new System.Drawing.Font("Segoe UI", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exampleLbl.Location = new System.Drawing.Point(12, 312);
            this.exampleLbl.Name = "exampleLbl";
            this.exampleLbl.Size = new System.Drawing.Size(776, 85);
            this.exampleLbl.TabIndex = 4;
            this.exampleLbl.Text = "(),";
            this.exampleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(682, 400);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(106, 38);
            this.exportBtn.TabIndex = 6;
            this.exportBtn.Text = "Выгрузить...";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // guidsCb
            // 
            this.guidsCb.AutoSize = true;
            this.guidsCb.Location = new System.Drawing.Point(12, 41);
            this.guidsCb.Name = "guidsCb";
            this.guidsCb.Size = new System.Drawing.Size(172, 19);
            this.guidsCb.TabIndex = 8;
            this.guidsCb.Text = "Добавить столбец ГУИДов";
            this.guidsCb.UseVisualStyleBackColor = true;
            this.guidsCb.CheckedChanged += new System.EventHandler(this.guidsCb_CheckedChanged);
            // 
            // eraseBtn
            // 
            this.eraseBtn.Location = new System.Drawing.Point(713, 11);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(75, 23);
            this.eraseBtn.TabIndex = 9;
            this.eraseBtn.Text = "Сброс";
            this.eraseBtn.UseVisualStyleBackColor = true;
            // 
            // importCsvBtn
            // 
            this.importCsvBtn.Location = new System.Drawing.Point(277, 11);
            this.importCsvBtn.Name = "importCsvBtn";
            this.importCsvBtn.Size = new System.Drawing.Size(101, 23);
            this.importCsvBtn.TabIndex = 12;
            this.importCsvBtn.Text = "Импорт CSV";
            this.importCsvBtn.UseVisualStyleBackColor = true;
            this.importCsvBtn.Click += new System.EventHandler(this.parseBtn_Click);
            // 
            // fieldsTree
            // 
            this.fieldsTree.AllowDrop = true;
            this.fieldsTree.Location = new System.Drawing.Point(12, 66);
            this.fieldsTree.Name = "fieldsTree";
            treeNode1.Name = "rootNode";
            treeNode1.Text = "Все поля";
            this.fieldsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.fieldsTree.Size = new System.Drawing.Size(407, 228);
            this.fieldsTree.TabIndex = 13;
            this.fieldsTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.fieldsTree_ItemDrag);
            this.fieldsTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fieldsTree_NodeMouseDoubleClick);
            this.fieldsTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.fieldsTree_DragDrop);
            this.fieldsTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.fieldsTree_DragEnter);
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(425, 66);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(75, 23);
            this.upBtn.TabIndex = 14;
            this.upBtn.Text = "/\\";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(425, 95);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(75, 23);
            this.downBtn.TabIndex = 15;
            this.downBtn.Text = "\\/";
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(425, 124);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "X";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(425, 153);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // importExcelBtn
            // 
            this.importExcelBtn.Location = new System.Drawing.Point(384, 11);
            this.importExcelBtn.Name = "importExcelBtn";
            this.importExcelBtn.Size = new System.Drawing.Size(101, 23);
            this.importExcelBtn.TabIndex = 18;
            this.importExcelBtn.Text = "Импорт Excel";
            this.importExcelBtn.UseVisualStyleBackColor = true;
            this.importExcelBtn.Click += new System.EventHandler(this.importExcelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.importExcelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.fieldsTree);
            this.Controls.Add(this.importCsvBtn);
            this.Controls.Add(this.eraseBtn);
            this.Controls.Add(this.guidsCb);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.exampleLbl);
            this.Controls.Add(label2);
            this.Controls.Add(this.chooseFileBtn);
            this.Controls.Add(label1);
            this.Controls.Add(this.fileNameTb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Files to SQL converter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

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