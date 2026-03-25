using System.Collections.Generic;

namespace Payment_App
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private bool isDataSaved = true;
        private bool isLoadingCustomerData = false;

        // Lưu payment method theo customer name (in-memory)
        private readonly Dictionary<string, string> customerPayments = new();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                textBox1.Text = "";
                isDataSaved = true;
                return;
            }

            isLoadingCustomerData = true;
            try
            {
                string customer = comboBox1.Text;
                textBox1.Text = customerPayments.GetValueOrDefault(customer, "");
                isDataSaved = true;
            }
            finally
            {
                isLoadingCustomerData = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var f = new Form2();
            DialogResult selectedButton = f.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                textBox1.Text = f.Tag?.ToString();
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Mike Smith");
            comboBox1.Items.Add("Nancy Jones");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            string customer = comboBox1.Text.Trim();
            string payment = textBox1.Text;

            customerPayments[customer] = payment; // lưu thật sự vào dictionary
            isDataSaved = true;

            MessageBox.Show("Data saved.", "Customer");
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            if (comboBox1.SelectedIndex == -1)
            {
                errorMessage += "You must select a customer.\n";
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorMessage += "You must enter a payment.\n";
            }

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Enter Error");
            }

            return success;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!isLoadingCustomerData)
            {
                isDataSaved = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDataSaved)
            {
                string message =
                    "This form contains unsaved data.\n\n" +
                    "Do you want to save it?";

                DialogResult button = MessageBox.Show(
                    message,
                    "Customer",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (button == DialogResult.Yes)
                {
                    if (IsValidData())
                    {
                        SaveData();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else if (button == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
