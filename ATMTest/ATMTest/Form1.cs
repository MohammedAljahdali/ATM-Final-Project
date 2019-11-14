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
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "1234")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Enter the correct Username or Password", "Invaild Username or Password", MessageBoxButtons.OK);
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
