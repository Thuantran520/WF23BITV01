namespace _16032026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Taoform_Click(object sender, EventArgs e)
        {
            int sodong, socot;
            if ((!int.TryParse(Txtsodong.Text, out sodong) || sodong < 1) || (!int.TryParse(Txtsocot.Text,out socot) || socot < 1 ) )
            {
                MessageBox.Show("Vui long nhap so nguyen day du va hop le", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            
            Form2 f2 = new Form2(sodong,socot);
            f2.soCot = socot; f2.soDong = sodong;
            f2.Show();
        }
    }
}
