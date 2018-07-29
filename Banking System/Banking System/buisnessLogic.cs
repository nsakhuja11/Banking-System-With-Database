using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class buisnessLogic : Database
    {
        public string type;
        public string name;
        public int accountNo;
        public int balance;
        //Database d = new Database();
        public int addAccount()
        {
            Console.WriteLine("Enter Account Type : Saving | Current | DMAT");
            type = Console.ReadLine();
            Console.WriteLine("Enter Customer Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number");
            accountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Initial Account Balance");
            balance = Convert.ToInt32(Console.ReadLine());
            Insert(type,name,accountNo,balance);
            return accountNo;
        }
        /*public int searchByAccountId(buisnessLogic[] acc, int no)
        {
            int index = 0;
            for (int i = 0; i < 10; i++)
            {
                if (acc[i].accountNo == no)
                {
                    index = i;
                }
            }
            return index;
        }*/
        public void deposit(int acc_no)
        {
            balance = RetreiveBalance(acc_no);
            int amount;
            Console.WriteLine("Enter Amount to Deposit");
            amount = Convert.ToInt32(Console.ReadLine());
            balance=balance+amount;
            Console.WriteLine("Updated Balance = {0}", balance);
            Update(acc_no, balance);
        }
        public void displayAccountDetails(int acc_no)
        {
            Display(acc_no);
        }

        public void withdraw(int acc_no)
        {
            int amount;
            Console.WriteLine("Enter Amount to Withdraw");
            amount = Convert.ToInt32(Console.ReadLine());
            balance = RetreiveBalance(acc_no);
            type = RetreiveType(acc_no);
            if (type == "Saving")
            {
                if ((balance - amount) < 1000)
                {
                    Console.WriteLine("You can not Withdraw");
                }
                else
                {
                    balance = balance - amount;
                }
            }
            else if (type == "Current")
            {
                if ((balance - amount) < 0)
                {
                    Console.WriteLine("You can not Withdraw");
                }
                else
                {
                    balance = balance - amount;
                }
            }
            else if (type == "DMAT")
            {
                if ((balance - amount) < -10000)
                {
                    Console.WriteLine("You can not Withdraw");
                }
                else
                {
                    balance = balance - amount;
                }
            }
            Console.WriteLine("Updated Balance = {0}", balance);
        }

        public void calculateInterest(int acc_no)
        {
            balance = RetreiveBalance(acc_no);
            type = RetreiveType(acc_no);
            if (type == "Saving")
            {
                balance = (balance / 100) * 4;
            }
            else if (type == "Current")
            {
                balance = balance / 100;
            }
            else if (type == "DMAT")
            {
                balance = 0;
            }
            Console.WriteLine("Interest = {0}", balance);
        }
    }

}
