namespace _16032026
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
            Taoform = new Button();
            Lsodong = new Label();
            Lsocot = new Label();
            Txtsodong = new TextBox();
            Txtsocot = new TextBox();
            SuspendLayout();
            // 
            // Taoform
            // 
            Taoform.Location = new Point(254, 74);
            Taoform.Name = "Taoform";
            Taoform.Size = new Size(117, 55);
            Taoform.TabIndex = 0;
            Taoform.Text = "Khoi tao from";
            Taoform.UseVisualStyleBackColor = true;
            Taoform.Click += Taoform_Click;
            // 
            // Lsodong
            // 
            Lsodong.AutoSize = true;
            Lsodong.Location = new Point(61, 74);
            Lsodong.Name = "Lsodong";
            Lsodong.Size = new Size(51, 15);
            Lsodong.TabIndex = 1;
            Lsodong.Text = "So dong";
            // 
            // Lsocot
            // 
            Lsocot.AutoSize = true;
            Lsocot.Location = new Point(61, 109);
            Lsocot.Name = "Lsocot";
            Lsocot.Size = new Size(40, 15);
            Lsocot.TabIndex = 2;
            Lsocot.Text = "So cot";
            // 
            // Txtsodong
            // 
            Txtsodong.Location = new Point(133, 70);
            Txtsodong.Name = "Txtsodong";
            Txtsodong.Size = new Size(100, 23);
            Txtsodong.TabIndex = 3;
            // 
            // Txtsocot
            // 
            Txtsocot.Location = new Point(133, 105);
            Txtsocot.Name = "Txtsocot";
            Txtsocot.Size = new Size(100, 23);
            Txtsocot.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 210);
            Controls.Add(Txtsocot);
            Controls.Add(Txtsodong);
            Controls.Add(Lsocot);
            Controls.Add(Lsodong);
            Controls.Add(Taoform);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Taoform;
        private Label Lsodong;
        private Label Lsocot;
        private TextBox Txtsodong;
        private TextBox Txtsocot;
    }
}
