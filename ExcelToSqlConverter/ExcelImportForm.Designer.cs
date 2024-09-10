namespace ExcelToSqlConverter
{
    partial class ExcelImportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listTb = new TextBox();
            headersCb = new CheckBox();
            okBtn = new Button();
            cancelBtn = new Button();
            defaultListCb = new CheckBox();
            label2 = new Label();
            chooseFileBtn = new Button();
            fileNameLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 41);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Лист:";
            // 
            // listTb
            // 
            listTb.Enabled = false;
            listTb.Location = new Point(84, 65);
            listTb.Name = "listTb";
            listTb.Size = new Size(171, 23);
            listTb.TabIndex = 1;
            // 
            // headersCb
            // 
            headersCb.AutoSize = true;
            headersCb.Location = new Point(10, 104);
            headersCb.Name = "headersCb";
            headersCb.Size = new Size(171, 19);
            headersCb.TabIndex = 2;
            headersCb.Text = "Первая строка заголовков";
            headersCb.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Enabled = false;
            okBtn.Location = new Point(236, 146);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 3;
            okBtn.Text = "ОК";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += CloseFormEvent;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(317, 146);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CloseFormEvent;
            // 
            // defaultListCb
            // 
            defaultListCb.AutoSize = true;
            defaultListCb.Checked = true;
            defaultListCb.CheckState = CheckState.Checked;
            defaultListCb.Location = new Point(52, 40);
            defaultListCb.Name = "defaultListCb";
            defaultListCb.Size = new Size(113, 19);
            defaultListCb.TabIndex = 5;
            defaultListCb.Text = "По-умолчанию";
            defaultListCb.UseVisualStyleBackColor = true;
            defaultListCb.CheckedChanged += defaultListCb_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 68);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 6;
            label2.Text = "Имя листа:";
            // 
            // chooseFileBtn
            // 
            chooseFileBtn.Location = new Point(10, 9);
            chooseFileBtn.Margin = new Padding(3, 2, 3, 2);
            chooseFileBtn.Name = "chooseFileBtn";
            chooseFileBtn.Size = new Size(114, 22);
            chooseFileBtn.TabIndex = 7;
            chooseFileBtn.Text = "Выбрать файл";
            chooseFileBtn.UseVisualStyleBackColor = true;
            chooseFileBtn.Click += chooseFileBtn_Click;
            // 
            // fileNameLbl
            // 
            fileNameLbl.AutoEllipsis = true;
            fileNameLbl.Location = new Point(130, 12);
            fileNameLbl.Name = "fileNameLbl";
            fileNameLbl.Size = new Size(262, 19);
            fileNameLbl.TabIndex = 8;
            fileNameLbl.Text = "label3";
            // 
            // ExcelImportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 181);
            Controls.Add(fileNameLbl);
            Controls.Add(chooseFileBtn);
            Controls.Add(label2);
            Controls.Add(defaultListCb);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(headersCb);
            Controls.Add(listTb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ExcelImportForm";
            Text = "Импорт Excel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox listTb;
        private CheckBox headersCb;
        private Button okBtn;
        private Button cancelBtn;
        private CheckBox defaultListCb;
        private Label label2;
        private Button chooseFileBtn;
        private Label fileNameLbl;
    }
}