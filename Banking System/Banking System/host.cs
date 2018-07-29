using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class host
    {
        public static void Main()
        {
            buisnessLogic Customer = new buisnessLogic();
            int haveAccount;
            Console.WriteLine("Enter 1 to add new account or 2 if your account exist");
            haveAccount = Convert.ToInt32(Console.ReadLine());
            if (haveAccount == 1)
            {
                int acc_no = Customer.addAccount();
                int wantToContinue = 1;
                while (wantToContinue == 1)
                {
                    int choice;
                    Console.WriteLine("Enter Your Choice");
                    Console.WriteLine("1 to Display Account Details");
                    Console.WriteLine("2 to Deposit Money");
                    Console.WriteLine("3 to Withdraw");
                    Console.WriteLine("4 to Calculate Interest");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {

                        case 1: Customer.displayAccountDetails(acc_no);
                            break;

                        case 2: Customer.deposit(acc_no);
                            break;

                        case 3: Customer.withdraw(acc_no);
                            break;

                        case 4: Customer.calculateInterest(acc_no);
                            break;
                    }
                    Console.WriteLine("If you want to continue type 1 else type 0 to exit");
                    wantToContinue = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Enter Your Account Number");
                int acc_no;
                acc_no = Convert.ToInt32(Console.ReadLine());
                int wantToContinue = 1;
                while (wantToContinue == 1)
                {
                    int choice;
                    Console.WriteLine("Enter Your Choice");
                    Console.WriteLine("1 to Display Account Details");
                    Console.WriteLine("2 to Deposit Money");
                    Console.WriteLine("3 to Withdraw");
                    Console.WriteLine("4 to Calculate Interest");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {

                        case 1: Customer.displayAccountDetails(acc_no);
                            break;

                        case 2: Customer.deposit(acc_no);
                            break;

                        case 3: Customer.withdraw(acc_no);
                            break;

                        case 4: Customer.calculateInterest(acc_no);
                            break;
                    }
                    Console.WriteLine("If you want to continue type 1 else type 0 to exit");
                    wantToContinue = Convert.ToInt32(Console.ReadLine());
                }
            }   
        }
    }
}
