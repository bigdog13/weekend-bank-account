using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekend_bank_project
{
    class reserve : bank
    {//not sure how to set up reserve
        private double amountSaved;


        //reserve consturctor receive init balance and value for amountsaved
        public reserve(double balance, double amountSaved) : base(balance)
        //assign value 
        {
            AmountSaved = amountSaved;

        }
        //property
        public double AmountSaved
        {
            get { return amountSaved; }
            set
            {
                if (value > 0)
                    amountSaved = value;
                else
                    Console.WriteLine("Amount Saved must be greater than 0");
            }
        }   //create method amount of interest earned-interest rate*acct balance//savings accunt should inherite methods credit and debit wiout redifing -
        public double CalculateAmountSaved()
        {//how much money did balacnce earn us
            return Balance * AmountSaved;
        }   }
}
