using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        public class Account
        {
            public double balance;
            public Account()
            {
                balance = 500.00;

            }
            public double deposit()
            {
                double NewBalance;
                double deposit;

                Console.WriteLine("please enter amount to deposit");
                deposit = Double.Parse(Console.ReadLine());
                NewBalance = balance + deposit;

                return NewBalance;
            }
            public double withdrawl()
            {
                double NewBalance;
                double withdrawl;

                Console.WriteLine("please enter amount to withdrawl");
                withdrawl = double.Parse(Console.ReadLine());
                NewBalance = balance - withdrawl;

                return NewBalance;
            }
        }
        static void Main(string[] args)
        {
            double NewBalance;
            string balance;
            Account bank = new Account();

            Console.WriteLine("your current balance is 500.00");
                Console.WriteLine("press d for deposit or press w for withdrawl");

            balance = Console.ReadLine();

            if(balance == "d")
            {
                NewBalance = bank.deposit();
                Console.WriteLine("your new balance is {0}", NewBalance);

            }

            if(balance == "w")
            {
                NewBalance = bank.withdrawl();
                Console.WriteLine("your new balance is {0}", NewBalance);
          }

            Console.ReadLine();       
        }
    }
}
