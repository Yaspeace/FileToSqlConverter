namespace ExcelToSqlConverter.Forms.Fields
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
            mainTextBox = new TextBox();
            okBtn = new Button();
            cancelBtn = new Button();
            separatorRb = new RadioButton();
            formatRb = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
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
            headerTb.Size = new Size(278, 23);
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
            // mainTextBox
            // 
            mainTextBox.Location = new Point(12, 161);
            mainTextBox.Name = "mainTextBox";
            mainTextBox.Size = new Size(278, 23);
            mainTextBox.TabIndex = 4;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(134, 199);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 5;
            okBtn.Text = "ОК";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(215, 199);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // separatorRb
            // 
            separatorRb.AutoSize = true;
            separatorRb.Location = new Point(6, 22);
            separatorRb.Name = "separatorRb";
            separatorRb.Size = new Size(93, 19);
            separatorRb.TabIndex = 7;
            separatorRb.TabStop = true;
            separatorRb.Text = "Резделитель";
            separatorRb.UseVisualStyleBackColor = true;
            // 
            // formatRb
            // 
            formatRb.AutoSize = true;
            formatRb.Location = new Point(6, 47);
            formatRb.Name = "formatRb";
            formatRb.Size = new Size(68, 19);
            formatRb.TabIndex = 8;
            formatRb.TabStop = true;
            formatRb.Text = "Формат";
            formatRb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(separatorRb);
            groupBox1.Controls.Add(formatRb);
            groupBox1.Location = new Point(12, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(104, 74);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Режим";
            // 
            // UnionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 234);
            Controls.Add(groupBox1);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(mainTextBox);
            Controls.Add(quotesCb);
            Controls.Add(headerTb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UnionForm";
            Text = "Свойства объединения";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox headerTb;
        private CheckBox quotesCb;
        private TextBox mainTextBox;
        private Button okBtn;
        private Button cancelBtn;
        private RadioButton separatorRb;
        private RadioButton formatRb;
        private GroupBox groupBox1;
    }
}