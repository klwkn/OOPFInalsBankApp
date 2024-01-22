using System.IO;
namespace OOPFInalsBankApp
{
    public partial class AccountPortal : Form
    {
        public AccountPortal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged_1(object sender, EventArgs e)
        {

        }
        private Dictionary<string, CustomerDesu> customerDictionary = new Dictionary<string, CustomerDesu>();

        private void lgnBTTN_Click(object sender, EventArgs e)
        {
            string enteredName = usernameField.Text;
            string enteredPassword = passwordField.Text;
            using (StreamReader reader = new StreamReader("customerDataInfo.txt"))
            {
                string line;
                bool isValidAccount = false;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        string name = parts[0];
                        string password = parts[1];
                        if (enteredName == name && enteredPassword == password)
                        {
                            isValidAccount = true;
                            break;
                        }
                    }
                }
                if (isValidAccount)
                {
                    MessageBox.Show("Login Successful!");
                    CrossRoads form2 = new CrossRoads();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User!");
                    usernameField.Clear();
                    passwordField.Clear();
                    usernameField.Focus();
                }
            }
        }

        private void clrfldsBTTN_Click(object sender, EventArgs e)
        {
            usernameField.Clear();
            passwordField.Clear();
            usernameField.Focus();
        }

        private void exitBTTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration form3 = new Registration();
            form3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}