using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMTest;

namespace ATMTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBalanceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Balance is: " +Program.balance+ " sar","Balance",MessageBoxButtons.OK);  
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            ATM form = new ATM();
            form.Show();
            this.Hide();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            WithdrawDepositForm form = new WithdrawDepositForm();
            form.setForm("Withdraw");
            form.Show();
            this.Hide();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            WithdrawDepositForm form = new WithdrawDepositForm();
            form.setForm("Deposit");
            form.Show();
            this.Hide();
        }

        
    }
}
