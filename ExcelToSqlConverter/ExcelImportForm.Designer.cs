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
            this.label1 = new System.Windows.Forms.Label();
            this.listTb = new System.Windows.Forms.TextBox();
            this.headersCb = new System.Windows.Forms.CheckBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.defaultListCb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лист:";
            // 
            // listTb
            // 
            this.listTb.Enabled = false;
            this.listTb.Location = new System.Drawing.Point(86, 33);
            this.listTb.Name = "listTb";
            this.listTb.Size = new System.Drawing.Size(171, 23);
            this.listTb.TabIndex = 1;
            // 
            // headersCb
            // 
            this.headersCb.AutoSize = true;
            this.headersCb.Location = new System.Drawing.Point(12, 72);
            this.headersCb.Name = "headersCb";
            this.headersCb.Size = new System.Drawing.Size(171, 19);
            this.headersCb.TabIndex = 2;
            this.headersCb.Text = "Первая строка заголовков";
            this.headersCb.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(182, 110);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "ОК";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.CloseFormEvent);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(101, 110);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CloseFormEvent);
            // 
            // defaultListCb
            // 
            this.defaultListCb.AutoSize = true;
            this.defaultListCb.Checked = true;
            this.defaultListCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultListCb.Location = new System.Drawing.Point(54, 8);
            this.defaultListCb.Name = "defaultListCb";
            this.defaultListCb.Size = new System.Drawing.Size(113, 19);
            this.defaultListCb.TabIndex = 5;
            this.defaultListCb.Text = "По-умолчанию";
            this.defaultListCb.UseVisualStyleBackColor = true;
            this.defaultListCb.CheckedChanged += new System.EventHandler(this.defaultListCb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя листа:";
            // 
            // ExcelImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 145);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.defaultListCb);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.headersCb);
            this.Controls.Add(this.listTb);
            this.Controls.Add(this.label1);
            this.Name = "ExcelImportForm";
            this.Text = "ExcelImportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox listTb;
        private CheckBox headersCb;
        private Button okBtn;
        private Button cancelBtn;
        private CheckBox defaultListCb;
        private Label label2;
    }
}