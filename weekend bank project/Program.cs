using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekend_bank_project
{
    class Program
    {
        static void Main(string[] args)
        {

            //create object

            checking credit = new checking("\n\n This is your current balance.");
            checking debit = new checking("\n\n This is your current balance.");




            do
            {


                Console.WriteLine("hello what type of transaction would you like to make?");

                Console.WriteLine("1.Checking");
                Console.WriteLine("2.Savings");
                Console.WriteLine("3.Reserve");
                int number = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (number)
                {
                    case 1:

                        //action
                        deposit or withdraw



                        break;

                    case 2:

                        //action
                        deposit or withdraw
                        break;

                    case 3:
                        //action
                        deposit or withdraw

                        break;

                    default:

                        break;



                }  while ("do you want another trasaction")
        }   }
               
}   }