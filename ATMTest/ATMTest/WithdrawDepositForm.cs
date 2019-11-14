using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMTest
{
    public partial class WithdrawDepositForm : Form
    {
        public WithdrawDepositForm()
        {
            InitializeComponent();
        }

        public void setForm(string title)
        {
            titleLabel.Text = title;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            string result = "";
            if (titleLabel.Text == "Withdraw")
            {
                if (sender.ToString() == "System.Windows.Forms.Button, Text: 500")
                {
                    result = Program.WithdrawCash(500);
                } else if (sender.ToString() == "System.Windows.Forms.Button, Text: 1000")
                {
                    result = Program.WithdrawCash(1000);
                } else if (sender.ToString() == "System.Windows.Forms.Button, Text: 1500")
                {
                    result = Program.WithdrawCash(1500);
                } else if (sender.ToString() == "System.Windows.Forms.Button, Text: 2000")
                {
                    result = Program.WithdrawCash(2000);
                } else if (sender.ToString() == "System.Windows.Forms.Button, Text: 5000")
                {
                    result = Program.WithdrawCash(5000);
                }
            } else if (titleLabel.Text == "Deposit")
            {
                if (sender.ToString() == "System.Windows.Forms.Button, Text: 500")
                {
                    Program.DepositCash(500);
                }
                else if (sender.ToString() == "System.Windows.Forms.Button, Text: 1000")
                {
                    Program.DepositCash(1000);
                }
                else if (sender.ToString() == "System.Windows.Forms.Button, Text: 1500")
                {
                    Program.DepositCash(1500);
                }
                else if (sender.ToString() == "System.Windows.Forms.Button, Text: 2000")
                {
                    Program.DepositCash(2000);
                }
                else if (sender.ToString() == "System.Windows.Forms.Button, Text: 5000")
                {
                    Program.DepositCash(5000);
                }
            }
            if (result == "")
            {
                Form2 form = new Form2();
                form.Show();
                titleLabel.Text = "";
                this.Hide();
            } else
            {
                MessageBox.Show(result, "Invaild Input", MessageBoxButtons.OK);
            }
        }

        private void otherAmountButton_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = int.Parse(otherAmountTextBox.Text);
                string result = "";
                if (titleLabel.Text == "Withdraw")
                {
                    result = Program.WithdrawCash(amount);
                } else if (titleLabel.Text == "Deposit")
                {
                    result = Program.DepositCash(amount);
                }
                if (result != "")
                {
                    MessageBox.Show(result, "Invaild Input", MessageBoxButtons.OK);
                } else
                {
                    Form2 form = new Form2();
                    form.Show();
                    titleLabel.Text = "";
                    this.Hide();
                }
            } catch
            {
                MessageBox.Show("Enter a vaild number", "Invaild Input", MessageBoxButtons.OK);
                
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            titleLabel.Text = "";
            this.Hide();
        }
    }
}
