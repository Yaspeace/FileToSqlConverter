namespace ExcelToSqlConverter
{
    partial class FieldPropertiesForm
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
            this.headerTb = new System.Windows.Forms.TextBox();
            this.quotesCb = new System.Windows.Forms.CheckBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заголовок:";
            // 
            // headerTb
            // 
            this.headerTb.Location = new System.Drawing.Point(12, 27);
            this.headerTb.Name = "headerTb";
            this.headerTb.Size = new System.Drawing.Size(156, 23);
            this.headerTb.TabIndex = 1;
            // 
            // quotesCb
            // 
            this.quotesCb.AutoSize = true;
            this.quotesCb.Location = new System.Drawing.Point(12, 56);
            this.quotesCb.Name = "quotesCb";
            this.quotesCb.Size = new System.Drawing.Size(74, 19);
            this.quotesCb.TabIndex = 2;
            this.quotesCb.Text = "Кавычки";
            this.quotesCb.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(93, 94);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "ОК";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(12, 94);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // FieldPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 135);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.quotesCb);
            this.Controls.Add(this.headerTb);
            this.Controls.Add(this.label1);
            this.Name = "FieldPropertiesForm";
            this.Text = "FieldPropertiesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox headerTb;
        private CheckBox quotesCb;
        private Button okBtn;
        private Button cancelBtn;
    }
}