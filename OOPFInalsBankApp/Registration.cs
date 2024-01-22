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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }        

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rgstrBTTN_Click(object sender, EventArgs e)
        {
            string customerName = inputName.Text;
            string customerPassword = passwordField.Text;
            string customerNumber = GenerateAccountNumber();
            decimal customerBalance;
            if (!decimal.TryParse(accbalField.Text, out customerBalance))
            {
                MessageBox.Show("Please enter a valid initial account balance as a whole number");
                return;
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("customerDataBalance.txt", true))
                {
                    writer.WriteLine($"{customerName}\t{customerBalance}");
                }
            }
            bool isDuplicate = CheckForDuplicateCustomer(customerName, customerPassword);
            if (isDuplicate)
            {
                MessageBox.Show("A customer already has the same name and password");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("customerDataInfo.txt", true))
                {
                    writer.WriteLine($"{customerName},{customerPassword}");
                }
                MessageBox.Show($"Registration Successful! Welcome {customerName}\nInitial account balance: ₱{accbalField.Text}.\nAccount Number: {customerNumber}");
                AccountPortal form1 = new AccountPortal();
                form1.Show();
                this.Hide();
            }
        }
        private bool CheckForDuplicateCustomer(string customerName, string customerPassword)
        {
            using (StreamReader reader = new StreamReader("customerDataInfo.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(','); 
                    if (parts.Length >= 2)
                    {
                        string existingName = parts[0];
                        string existingPassword = parts[1];
                        if (existingName == customerName || existingPassword == customerPassword)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private string GenerateAccountNumber()
        {
            Random random = new Random();
            string AccountNumber = random.Next(100000000, 999999999).ToString();
            return AccountNumber;
        }

        private void exitBTTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void accbalField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
