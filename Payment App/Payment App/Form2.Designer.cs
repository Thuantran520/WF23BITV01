namespace Payment_App
{
    partial class Form2
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
            Billing = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            Billing.SuspendLayout();
            SuspendLayout();
            // 
            // Billing
            // 
            Billing.Controls.Add(radioButton2);
            Billing.Controls.Add(radioButton1);
            Billing.Location = new Point(28, 12);
            Billing.Name = "Billing";
            Billing.Size = new Size(375, 100);
            Billing.TabIndex = 0;
            Billing.TabStop = false;
            Billing.Text = "Billing";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(193, 41);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bill customer";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Credit card";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += Billing_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 138);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 1;
            label1.Text = "Credit card type:";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Visa", "Mastercard", "American Express" });
            listBox1.Location = new Point(157, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 88);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 249);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 4;
            label2.Text = "Credit card type:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 307);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 6;
            label3.Text = "Expiration date:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormatString = "MMMM";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(157, 305);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Location = new Point(284, 305);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(28, 357);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(227, 25);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Set as default billing method";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(205, 404);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 13;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(313, 404);
            button2.Name = "button2";
            button2.Size = new Size(92, 23);
            button2.TabIndex = 14;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(Billing);
            Name = "Form2";
            Text = "Payment";
            Load += Form2_Load_1;
            Billing.ResumeLayout(false);
            Billing.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Billing;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
    }
}