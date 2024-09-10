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
            label2 = new Label();
            groupBox1 = new GroupBox();
            replaceTb = new TextBox();
            label3 = new Label();
            replaceWithTb = new TextBox();
            label4 = new Label();
            formatTb = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Заголовок:";
            // 
            // headerTb
            // 
            headerTb.Location = new Point(86, 12);
            headerTb.Name = "headerTb";
            headerTb.Size = new Size(304, 23);
            headerTb.TabIndex = 1;
            // 
            // quotesCb
            // 
            quotesCb.AutoSize = true;
            quotesCb.CheckAlign = ContentAlignment.MiddleRight;
            quotesCb.Location = new Point(27, 41);
            quotesCb.Name = "quotesCb";
            quotesCb.Size = new Size(77, 19);
            quotesCb.TabIndex = 2;
            quotesCb.Text = "Кавычки:";
            quotesCb.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(235, 206);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 3;
            okBtn.Text = "ОК";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(316, 206);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Заменять:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(replaceWithTb);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(replaceTb);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Замена";
            // 
            // replaceTb
            // 
            replaceTb.Location = new Point(74, 22);
            replaceTb.Name = "replaceTb";
            replaceTb.Size = new Size(297, 23);
            replaceTb.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 54);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 7;
            label3.Text = "На:";
            // 
            // replaceWithTb
            // 
            replaceWithTb.Location = new Point(74, 51);
            replaceWithTb.Name = "replaceWithTb";
            replaceWithTb.Size = new Size(297, 23);
            replaceWithTb.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 69);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Формат:";
            // 
            // formatTb
            // 
            formatTb.Location = new Point(86, 66);
            formatTb.Name = "formatTb";
            formatTb.Size = new Size(304, 23);
            formatTb.TabIndex = 8;
            // 
            // FieldPropertiesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 241);
            Controls.Add(formatTb);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(quotesCb);
            Controls.Add(headerTb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FieldPropertiesForm";
            Text = "Свойства поля";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox headerTb;
        private CheckBox quotesCb;
        private Button okBtn;
        private Button cancelBtn;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox replaceWithTb;
        private Label label3;
        private TextBox replaceTb;
        private Label label4;
        private TextBox formatTb;
    }
}