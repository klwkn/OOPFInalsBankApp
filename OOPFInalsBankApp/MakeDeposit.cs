using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOPFInalsBankApp
{
    public partial class MakeDeposit : Form
    {
        public MakeDeposit()
        {
            InitializeComponent();
        }

        private void MakeDeposit_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dpstBTTN_Click(object sender, EventArgs e)
        {
            string customerName = accField.Text;
            decimal depositAmount;
            if (decimal.TryParse(depositField.Text, out depositAmount) && depositAmount > 0)
            {
                decimal customerBalance = GetCustomerBalanceFromDataSource(customerName);
                decimal updatedcustomerBalance = customerBalance + depositAmount;
                UpdatedCustomerBalanceInDataSource(customerName, customerBalance);
                MessageBox.Show($"Deposit Successful!\nAmount Deposited: ₱{depositAmount.ToString("N2")} to {customerName}\nUpdated Account Balance: ₱{updatedcustomerBalance}");
            }
            else
            {
                MessageBox.Show("Please enter a valid amount greater than zero.");
            }
            string message = "Do you want to make another deposit?";
            string title = "Money?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MakeDeposit form3 = new MakeDeposit();
                form3.Show();
                this.Hide();
            }
            else
            {
                AccountPortal form1 = new AccountPortal();
                form1.Show();
                this.Hide();
            }
        }
        private decimal GetCustomerBalanceFromDataSource(string customerName)
        {
            using (StreamReader reader = new StreamReader("customerDataBalance.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('\t');
                    if (parts[0] == customerName)
                    {
                        if (decimal.TryParse(parts[1], out decimal customerBalance))
                        {
                            return customerBalance;
                        }
                        else
                        {
                            MessageBox.Show("Balance is not a valid decimal");
                            return 0;
                        }
                    }
                }
            }
            return 0;
        }
        private void UpdatedCustomerBalanceInDataSource(string customerName, decimal updatedcustomerBalance)
        {
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader("customerDataBalance.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('\t');
                    if (parts[0] == customerName)
                    {
                        parts[1] = updatedcustomerBalance.ToString();
                        line = string.Join("\t", parts);
                    }
                    lines.Add(line);
                }
            }
            using (StreamWriter writer = new StreamWriter("customerDataBalance.txt"))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        private void clrfldsBTTN_Click(object sender, EventArgs e)
        {
            accField.Clear();
            depositField.Clear();
            accField.Focus();
        }

        private void exitBTTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void depositField_TextChanged(object sender, EventArgs e)
        {

        }

        private void accFields_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
