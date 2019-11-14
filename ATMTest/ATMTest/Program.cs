using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMTest
{
    static class Program
    {
        const string username = "Admin";
        const string password = "1234";
        public static int balance = 20000;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ATM());
        }

        public static string WithdrawCash(int amount)
        {
            if (amount % 50 == 0)
            {
                if (balance - amount < 0)
                {
                    return "Your Balance is Less than the Amount You Entered!";
                } else if (amount < 0)
                {
                    return "You Can Not Withdraw a Negtiave Value";
                }
                balance = balance - amount;
                return "";
            } else
            {
                return "Enter multiples of 50.";
            }
        }

        public static String DepositCash(int amount)
        {
            if (amount < 0)
                return "You Can Not Deposit a Negtiave Value";
            balance = balance + amount;
            return "";  
        }
        

    }
}
