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
    public partial class CrossRoads : Form
    {
        public CrossRoads()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void exitBTTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void makeWithdrawal_Click(object sender, EventArgs e)
        {
            MakeWithdrawal form4 = new MakeWithdrawal();
            form4.Show();
            this.Hide();
        }

        private void makeDeposit_Click(object sender, EventArgs e)
        {
            MakeDeposit form3 = new MakeDeposit();
            form3.Show();
            this.Hide();
        }

        private void backToAccountPortal_Click(object sender, EventArgs e)
        {
            AccountPortal form1 = new AccountPortal();
            form1.Show();
            this.Hide();
        }
    }
}
