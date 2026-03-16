using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace _16032026
{
    public partial class Form2 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int  soDong {  get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int soCot { get; set; }



        public Form2(int dong, int cot)
        {
            InitializeComponent();
            soDong = dong;
            soCot = cot;

        }
        const int CellSize = 50;
        const int Spacing = 20;

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    var btn = new Button();
                    btn.Size = new Size(CellSize, Spacing);
                    btn.Left = Spacing + j * (CellSize + Spacing);
                    btn.Top = Spacing + i * (CellSize + Spacing);
                    btn.Text = $"({i},{j})";
                    this.Controls.Add(btn);
                }
                this.Width = Spacing + soCot * (CellSize + Spacing) + 15;
                this.Height = Spacing + soDong * (CellSize + Spacing) + 30;
            }

        }
    }
}
