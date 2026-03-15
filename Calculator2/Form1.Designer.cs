namespace Calculator2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInputN = new TextBox();
            btnTinhTong = new Button();
            groupBox1 = new GroupBox();
            txtKetQuaS = new TextBox();
            txtChuoiS = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtInputN
            // 
            txtInputN.Location = new Point(24, 41);
            txtInputN.Name = "txtInputN";
            txtInputN.Size = new Size(100, 23);
            txtInputN.TabIndex = 0;
            // 
            // btnTinhTong
            // 
            btnTinhTong.Location = new Point(149, 41);
            btnTinhTong.Name = "btnTinhTong";
            btnTinhTong.Size = new Size(75, 23);
            btnTinhTong.TabIndex = 1;
            btnTinhTong.Text = "Tinh";
            btnTinhTong.UseVisualStyleBackColor = true;
            btnTinhTong.Click += btnTinhTong_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKetQuaS);
            groupBox1.Controls.Add(txtChuoiS);
            groupBox1.Location = new Point(24, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "KetQua";
            // 
            // txtKetQuaS
            // 
            txtKetQuaS.Location = new Point(6, 71);
            txtKetQuaS.Name = "txtKetQuaS";
            txtKetQuaS.Size = new Size(100, 23);
            txtKetQuaS.TabIndex = 4;
            // 
            // txtChuoiS
            // 
            txtChuoiS.Location = new Point(6, 22);
            txtChuoiS.Name = "txtChuoiS";
            txtChuoiS.Size = new Size(100, 23);
            txtChuoiS.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 223);
            Controls.Add(groupBox1);
            Controls.Add(btnTinhTong);
            Controls.Add(txtInputN);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputN;
        private Button btnTinhTong;
        private GroupBox groupBox1;
        private TextBox txtKetQuaS;
        private TextBox txtChuoiS;
    }
}
