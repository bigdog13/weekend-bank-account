using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekend_bank_project
{
    class checking :bank
    {
        private double fee;
        //constructor get balance and fee amount

        public checking(double balance, double fee) : base(balance)
        //passing fee into constuctor
        {
            Fee = fee = 5;
        }
        public double Fee
        {
            get { return fee; }
            set { fee = value; }


        }
        public override void Credit(double amount)
        {//passing base and  debit amount
            base.Credit(amount);
            Balance -= fee;
        }
        //passing base and withdraw amount
        public override void Debit(double amount)


        {
            base.Debit(amount);
        }

    }
}
