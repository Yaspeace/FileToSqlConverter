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
            label1 = new Label();
            headerTb = new TextBox();
            quotesCb = new CheckBox();
            okBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Заголовок:";
            // 
            // headerTb
            // 
            headerTb.Location = new Point(12, 27);
            headerTb.Name = "headerTb";
            headerTb.Size = new Size(156, 23);
            headerTb.TabIndex = 1;
            // 
            // quotesCb
            // 
            quotesCb.AutoSize = true;
            quotesCb.Location = new Point(12, 56);
            quotesCb.Name = "quotesCb";
            quotesCb.Size = new Size(74, 19);
            quotesCb.TabIndex = 2;
            quotesCb.Text = "Кавычки";
            quotesCb.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(12, 100);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 3;
            okBtn.Text = "ОК";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(93, 100);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // FieldPropertiesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 135);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(quotesCb);
            Controls.Add(headerTb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FieldPropertiesForm";
            Text = "Свойства поля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox headerTb;
        private CheckBox quotesCb;
        private Button okBtn;
        private Button cancelBtn;
    }
}