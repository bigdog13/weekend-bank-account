using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekend_bank_project
{
    class bank
    {
        
        
            //declare variable fields//protected accessible in base and derived class
            protected int accountNum;
        protected string owner;
        protected double balance;
        // DateTime lastTransactionDate;
        //double lastTransactionBalance;

        //constructor
        public bank(string Owner)
        {

        }
        //property
        public string ownerinfo
        {
            get { return owner; }
            set { owner = value; }
        }

        public bank(double balance)
        {
            Balance = balance;
        }
        //property for initial balance
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be negative");

            }
        }
        //method for Deposit(credit) into current balance
        public virtual void Credit(double amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                Console.WriteLine("Deposit must be greater than zero");
        }
        //method for withdrawl(debit)from current balance
        public virtual void Debit(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
            }

            else if (Balance < amount)
            {
                Console.WriteLine("Withdrawal amount exceeded account balance");
            }
        }
    }   }       