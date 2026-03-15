namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(textBox1.Text);
                textBox2.Text = (input * 26000).ToString() + " VND";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"[^0-9\.]") ||
                System.Text.RegularExpressions.Regex.Matches(textBox1.Text, @"\.").Count > 1)
            {
                MessageBox.Show("Please enter only numbers or a single decimal point.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}
