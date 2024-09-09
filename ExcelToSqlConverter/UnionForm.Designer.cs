namespace ExcelToSqlConverter
{
    partial class UnionForm
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
            label2 = new Label();
            splitterTb = new TextBox();
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
            headerTb.Size = new Size(155, 23);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Разделитель:";
            // 
            // splitterTb
            // 
            splitterTb.Location = new Point(12, 96);
            splitterTb.Name = "splitterTb";
            splitterTb.Size = new Size(155, 23);
            splitterTb.TabIndex = 4;
            // 
            // okBtn
            // 
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(12, 135);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 5;
            okBtn.Text = "ОК";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(92, 135);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // UnionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(181, 170);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(splitterTb);
            Controls.Add(label2);
            Controls.Add(quotesCb);
            Controls.Add(headerTb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UnionForm";
            Text = "Свойства объединения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox headerTb;
        private CheckBox quotesCb;
        private Label label2;
        private TextBox splitterTb;
        private Button okBtn;
        private Button cancelBtn;
    }
}