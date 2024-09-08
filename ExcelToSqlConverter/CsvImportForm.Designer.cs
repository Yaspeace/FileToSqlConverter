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
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Разделитель:";
            // 
            // splitterCb
            // 
            splitterCb.FormattingEnabled = true;
            splitterCb.Location = new Point(116, 64);
            splitterCb.Margin = new Padding(3, 4, 3, 4);
            splitterCb.Name = "splitterCb";
            splitterCb.Size = new Size(138, 28);
            splitterCb.TabIndex = 1;
            // 
            // customSplitterCb
            // 
            customSplitterCb.AutoSize = true;
            customSplitterCb.Location = new Point(44, 102);
            customSplitterCb.Margin = new Padding(3, 4, 3, 4);
            customSplitterCb.Name = "customSplitterCb";
            customSplitterCb.Size = new Size(66, 24);
            customSplitterCb.TabIndex = 2;
            customSplitterCb.Text = "Свой";
            customSplitterCb.UseVisualStyleBackColor = true;
            customSplitterCb.CheckedChanged += customSplitterCb_CheckedChanged;
            // 
            // customSplitterTb
            // 
            customSplitterTb.Location = new Point(116, 100);
            customSplitterTb.Margin = new Padding(3, 4, 3, 4);
            customSplitterTb.Name = "customSplitterTb";
            customSplitterTb.Size = new Size(165, 27);
            customSplitterTb.TabIndex = 3;
            customSplitterTb.Visible = false;
            // 
            // headersLineCb
            // 
            headersLineCb.AutoSize = true;
            headersLineCb.Location = new Point(12, 144);
            headersLineCb.Margin = new Padding(3, 4, 3, 4);
            headersLineCb.Name = "headersLineCb";
            headersLineCb.Size = new Size(216, 24);
            headersLineCb.TabIndex = 4;
            headersLineCb.Text = "Первая строка заголовков";
            headersLineCb.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(272, 193);
            okBtn.Margin = new Padding(3, 4, 3, 4);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(86, 31);
            okBtn.TabIndex = 5;
            okBtn.Text = "ОК";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += CloseFormEvent;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(364, 193);
            cancelBtn.Margin = new Padding(3, 4, 3, 4);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(86, 31);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CloseFormEvent;
            // 
            // chooseFileBtn
            // 
            chooseFileBtn.Location = new Point(12, 12);
            chooseFileBtn.Name = "chooseFileBtn";
            chooseFileBtn.Size = new Size(125, 29);
            chooseFileBtn.TabIndex = 7;
            chooseFileBtn.Text = "Выбрать файл";
            chooseFileBtn.UseVisualStyleBackColor = true;
            chooseFileBtn.Click += chooseFileBtn_Click;
            // 
            // chosenFileNameLbl
            // 
            chosenFileNameLbl.AutoEllipsis = true;
            chosenFileNameLbl.Location = new Point(143, 16);
            chosenFileNameLbl.Name = "chosenFileNameLbl";
            chosenFileNameLbl.Size = new Size(307, 20);
            chosenFileNameLbl.TabIndex = 8;
            chosenFileNameLbl.Text = "label2";
            // 
            // CsvImportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 237);
            Controls.Add(chosenFileNameLbl);
            Controls.Add(chooseFileBtn);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(headersLineCb);
            Controls.Add(customSplitterTb);
            Controls.Add(customSplitterCb);
            Controls.Add(splitterCb);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CsvImportForm";
            Text = "CsvImportForm";
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