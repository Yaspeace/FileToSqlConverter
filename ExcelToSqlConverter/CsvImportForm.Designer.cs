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
            this.label1 = new System.Windows.Forms.Label();
            this.splitterCb = new System.Windows.Forms.ComboBox();
            this.customSplitterCb = new System.Windows.Forms.CheckBox();
            this.customSplitterTb = new System.Windows.Forms.TextBox();
            this.headersLineCb = new System.Windows.Forms.CheckBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разделитель:";
            // 
            // splitterCb
            // 
            this.splitterCb.FormattingEnabled = true;
            this.splitterCb.Location = new System.Drawing.Point(96, 6);
            this.splitterCb.Name = "splitterCb";
            this.splitterCb.Size = new System.Drawing.Size(121, 23);
            this.splitterCb.TabIndex = 1;
            // 
            // customSplitterCb
            // 
            this.customSplitterCb.AutoSize = true;
            this.customSplitterCb.Location = new System.Drawing.Point(12, 37);
            this.customSplitterCb.Name = "customSplitterCb";
            this.customSplitterCb.Size = new System.Drawing.Size(54, 19);
            this.customSplitterCb.TabIndex = 2;
            this.customSplitterCb.Text = "Свой";
            this.customSplitterCb.UseVisualStyleBackColor = true;
            this.customSplitterCb.CheckedChanged += new System.EventHandler(this.customSplitterCb_CheckedChanged);
            // 
            // customSplitterTb
            // 
            this.customSplitterTb.Location = new System.Drawing.Point(72, 35);
            this.customSplitterTb.Name = "customSplitterTb";
            this.customSplitterTb.Size = new System.Drawing.Size(145, 23);
            this.customSplitterTb.TabIndex = 3;
            this.customSplitterTb.Visible = false;
            // 
            // headersLineCb
            // 
            this.headersLineCb.AutoSize = true;
            this.headersLineCb.Location = new System.Drawing.Point(12, 75);
            this.headersLineCb.Name = "headersLineCb";
            this.headersLineCb.Size = new System.Drawing.Size(171, 19);
            this.headersLineCb.TabIndex = 4;
            this.headersLineCb.Text = "Первая строка заголовков";
            this.headersLineCb.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(142, 115);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "ОК";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.CloseFormEvent);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(12, 115);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CloseFormEvent);
            // 
            // CsvImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 150);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.headersLineCb);
            this.Controls.Add(this.customSplitterTb);
            this.Controls.Add(this.customSplitterCb);
            this.Controls.Add(this.splitterCb);
            this.Controls.Add(this.label1);
            this.Name = "CsvImportForm";
            this.Text = "CsvImportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox splitterCb;
        private CheckBox customSplitterCb;
        private TextBox customSplitterTb;
        private CheckBox headersLineCb;
        private Button okBtn;
        private Button cancelBtn;
    }
}