using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFInalsBankApp
{
    public partial class MakeWithdrawal : Form
    {
        public MakeWithdrawal()
        {
            InitializeComponent();
        }

        private void MakeWithdrawal_Load(object sender, EventArgs e)
        {

        }

        private void wthdrwlBTTN_Click(object sender, EventArgs e)
        {
            string customerName = accField.Text;
            decimal withdrawalAmount;
            if (decimal.TryParse(wthdrwlField.Text, out withdrawalAmount) && withdrawalAmount >= 50)
            {
                decimal customerBalance = GetCustomerBalanceFromDataSource(customerName);
                decimal updatedcustomerBalance = customerBalance - withdrawalAmount;
                UpdatedCustomerBalanceInDataSource(customerName, customerBalance);
                MessageBox.Show($"Withdrawal Successful!\nAmount Withdrawn: ₱{withdrawalAmount.ToString("N2")} from {customerName}\nUpdated Account Balance: ₱{updatedcustomerBalance}");
            }
            else
            {
                MessageBox.Show("ERROR!\nWithdrawal amount is below or not equal to the minimum amount of ₱50.00");
            }
            string message = "Do you want to make another deposit?";
            string title = "Money?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MakeWithdrawal form4 = new MakeWithdrawal();
                form4.Show();
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

        private void exitBTTN_Click(object sender, EventArgs e)
        {

        }

        private void accField_TextChanged(object sender, EventArgs e)
        {

        }

        private void wthdrwlField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
