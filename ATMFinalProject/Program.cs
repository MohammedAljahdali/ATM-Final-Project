using System;

namespace ATMFinalProject
{
    class MainClass
    {

        const string username = "admin";
        const int password = 1234;
        static int balance = 20000;

        public static void Main(string[] args)
        {
            ATMChoices();
        }

        public static void CheckBalance()
        {
            Console.WriteLine("Your Balance is {0}", MainClass.balance);
        }

        public static void WithdrawCash()
        {
          try
            {
                Console.Write("Enter the Amount You Want to Draw: ");
                int amount = int.Parse(Console.ReadLine());
                if (amount % 500 == 0 && !(MainClass.balance - amount < 0))
                {
                    MainClass.balance = MainClass.balance - amount;
                    Console.WriteLine("Withdraw is Completed.\nYour Balance is {0}", MainClass.balance);
                }
                else if (MainClass.balance - amount < 0)
                {
                    Console.WriteLine("Withdraw is Not Completed! You do not have enough balance");
                }
                else
                {
                    Console.WriteLine("Withdraw is Not Completed! Please Enter Amount of 500 Multiples.");
                }
            }  catch
            {
                Console.WriteLine("Wrong Input!");
                return;
            }
        }

        public static void DepositCash()
        {
            try
            { 
                Console.Write("Enter the Amount You Want to Deposit: ");
                int amount = int.Parse(Console.ReadLine());
                MainClass.balance = MainClass.balance + amount;
                Console.WriteLine("Deposit is Completed.\nYour Balance is {0}", MainClass.balance);
            }
            catch
            {
                Console.WriteLine("Wrong Input!");
                return;
            }
        }

        public static void ATMChoices()
        {
            int choice = 0;
            if (!CheckUser())
            {
                Console.Write("Wrong Username or Password!\nTry Again Later.");
                choice = 4;
            }
            
            while (choice != 4)
            {
                Console.Clear();
                Console.WriteLine("********Welcome To ATM Service**************" +
                 "\n1.Check Balance" +
                 "\n2.Withdraw Cash" +
                 "\n3.Deposit Cash" +
                 "\n4.Quit" +
                 "\n* ********************************************");
                Console.Write("Enter Your Choice: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                } catch
                {
                    Console.WriteLine("Wrong Input!");
                    Console.ReadKey();
                    continue;
                }
                

                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        WithdrawCash();
                        break;
                    case 3:
                        DepositCash();
                        break;
                    case 4:
                        Console.Write("Thank You for Using the ATM Program.");
                        break;
                    default:
                        Console.WriteLine("Sorry Invalid Choice! Try Again!");
                        break;
                }
                Console.WriteLine("Press Any Key to Continue.");
                Console.ReadKey();
            }
            


        }

        public static bool CheckUser()
        {
            Console.Write("Enter Your Username: ");
            string usernameInput = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            try
            {
                int passwordInput = int.Parse(Console.ReadLine());
                return password == passwordInput && usernameInput == username;
            } catch
            {
                return false;
            }    
        }


    }
}
