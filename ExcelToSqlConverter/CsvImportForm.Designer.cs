namespace ExcelToSqlConverter
{
    partial class CsvImportForm
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
            splitterCb = new ComboBox();
            customSplitterCb = new CheckBox();
            customSplitterTb = new TextBox();
            headersLineCb = new CheckBox();
            okBtn = new Button();
            cancelBtn = new Button();
            chooseFileBtn = new Button();
            chosenFileNameLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 50);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Разделитель:";
            // 
            // splitterCb
            // 
            splitterCb.FormattingEnabled = true;
            splitterCb.Location = new Point(102, 48);
            splitterCb.Name = "splitterCb";
            splitterCb.Size = new Size(121, 23);
            splitterCb.TabIndex = 1;
            // 
            // customSplitterCb
            // 
            customSplitterCb.AutoSize = true;
            customSplitterCb.Location = new Point(38, 76);
            customSplitterCb.Name = "customSplitterCb";
            customSplitterCb.Size = new Size(54, 19);
            customSplitterCb.TabIndex = 2;
            customSplitterCb.Text = "Свой";
            customSplitterCb.UseVisualStyleBackColor = true;
            customSplitterCb.CheckedChanged += customSplitterCb_CheckedChanged;
            // 
            // customSplitterTb
            // 
            customSplitterTb.Location = new Point(102, 75);
            customSplitterTb.Name = "customSplitterTb";
            customSplitterTb.Size = new Size(145, 23);
            customSplitterTb.TabIndex = 3;
            customSplitterTb.Visible = false;
            // 
            // headersLineCb
            // 
            headersLineCb.AutoSize = true;
            headersLineCb.Location = new Point(10, 108);
            headersLineCb.Name = "headersLineCb";
            headersLineCb.Size = new Size(171, 19);
            headersLineCb.TabIndex = 4;
            headersLineCb.Text = "Первая строка заголовков";
            headersLineCb.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Enabled = false;
            okBtn.Location = new Point(238, 146);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 5;
            okBtn.Text = "ОК";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += CloseFormEvent;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(319, 146);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CloseFormEvent;
            // 
            // chooseFileBtn
            // 
            chooseFileBtn.Location = new Point(10, 9);
            chooseFileBtn.Margin = new Padding(3, 2, 3, 2);
            chooseFileBtn.Name = "chooseFileBtn";
            chooseFileBtn.Size = new Size(109, 22);
            chooseFileBtn.TabIndex = 7;
            chooseFileBtn.Text = "Выбрать файл";
            chooseFileBtn.UseVisualStyleBackColor = true;
            chooseFileBtn.Click += chooseFileBtn_Click;
            // 
            // chosenFileNameLbl
            // 
            chosenFileNameLbl.AutoEllipsis = true;
            chosenFileNameLbl.Location = new Point(125, 12);
            chosenFileNameLbl.Name = "chosenFileNameLbl";
            chosenFileNameLbl.Size = new Size(269, 15);
            chosenFileNameLbl.TabIndex = 8;
            chosenFileNameLbl.Text = "label2";
            // 
            // CsvImportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 181);
            Controls.Add(chosenFileNameLbl);
            Controls.Add(chooseFileBtn);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(headersLineCb);
            Controls.Add(customSplitterTb);
            Controls.Add(customSplitterCb);
            Controls.Add(splitterCb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(420, 220);
            Name = "CsvImportForm";
            Text = "Импорт CSV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox splitterCb;
        private CheckBox customSplitterCb;
        private TextBox customSplitterTb;
        private CheckBox headersLineCb;
        private Button okBtn;
        private Button cancelBtn;
        private Button chooseFileBtn;
        private Label chosenFileNameLbl;
    }
}