using System;
using System.Windows.Forms;

namespace Payment_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // wire cancel behavior without touching Designer
            button2.Click += button2_Click;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // keep this if you later switch Designer load event to Form2_Load
            InitializePaymentInputs();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            // currently wired by Designer
            InitializePaymentInputs();
        }

        private void InitializePaymentInputs()
        {
            // avoid duplicate items
            listBox1.Items.Clear();
            listBox1.Items.Add("Visa");
            listBox1.Items.Add("Mastercard");
            listBox1.Items.Add("American Express");
            listBox1.SelectedIndex = 0;

            comboBox1.Items.Clear();
            string[] months =
            {
                "Select a month...",
                "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December"
            };
            comboBox1.Items.AddRange(months);
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Clear();
            comboBox2.Items.Add("Select a year...");
            int year = DateTime.Today.Year;
            int endYear = year + 8;
            while (year <= endYear)
            {
                comboBox2.Items.Add(year.ToString());
                year++;
            }
            comboBox2.SelectedIndex = 0;

            // allow typing + suggest
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDown;

            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

            // default mode
            radioButton1.Checked = true; // credit card
            Billing_CheckedChanged(this, EventArgs.Empty);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
            }
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool IsValidData()
        {
            bool success = true;

            if (checkBox1.Checked)
            {
                string errorMessage = "";

                if (listBox1.SelectedIndex == -1)
                    errorMessage += "Select a credit card type.\n";

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                    errorMessage += "Enter a credit card number.\n";

                if (comboBox1.SelectedIndex == 0 || string.IsNullOrWhiteSpace(comboBox1.Text))
                    errorMessage += "Select a month.\n";

                if (comboBox2.SelectedIndex == 0 || string.IsNullOrWhiteSpace(comboBox2.Text))
                    errorMessage += "Select a year.\n";

                if (errorMessage != "")
                {
                    success = false;
                    MessageBox.Show(errorMessage, "Entry Error");
                }
            }

            return success;
        }

        private void SaveData()
        {
            string nl = Environment.NewLine;
            string msg = "";

            if (radioButton1.Checked)
            {
                msg += "Charge to credit card." + nl + nl;
                msg += "Card type: " + listBox1.Text + nl;
                msg += "Card number: " + textBox1.Text + nl;
                msg += "Expiration date: " + comboBox1.Text + "/" + comboBox2.Text + nl;
            }
            else
            {
                msg += "Send bill to customer." + nl + nl;
            }

            bool isDefaultBilling = checkBox1.Checked;
            msg += "Default billing: " + isDefaultBilling;

            Tag = msg;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Billing_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                DisableControls(); // bill customer -> no card input
            else
                EnableControls();  // credit card -> enable input
        }

        private void EnableControls()
        {
            listBox1.Enabled = true;
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
        }

        private void DisableControls()
        {
            listBox1.Enabled = false;
            textBox1.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
        }
    }
}

