namespace VeHinhDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawLine(Pens.Red, 10, 10, 200, 10);
            g.DrawRectangle(Pens.Green, 10, 30, 100, 50);
            g.DrawString("23BITV01", new Font("Arial", 20), Brushes.Blue, 10, 100);
            g.FillEllipse(Brushes.Yellow, 150, 150, 100, 50);

            g.DrawPolygon(new Pen(Color.Purple, 3), new Point[] { new Point(300, 10), new Point(350, 50), new Point(300, 90) });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
