using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for number of diners in their party
            Console.WriteLine("How many in your party?");
            double totalNumberofPeople = double.Parse(Console.ReadLine());

            //ask user how much each diner is contributing to bill
            Console.WriteLine("How much is each paying?");
            double eachPaid = double.Parse(Console.ReadLine());
            
            //make expressions for calculations of various final bill options after possible discounts
            double totalAmount = totalNumberofPeople * eachPaid;
            double fiveDiscount = (totalAmount - (totalAmount * .05d));
            double tenDiscount = (totalAmount - (totalAmount * .10d));

            //use conditionals to determine if user is eligible for discounts and print final bill for them
            if (totalAmount >= 50)
            {

                Console.WriteLine("Your final bill before any discounts is: $" + totalAmount);
                Console.WriteLine("Your Final Bill after Discount: $" + tenDiscount);
                Console.WriteLine("Congratualations! You have received a 10% discount on your bill. Thanks you for your patronage.");
            }
            else
            {
                Console.WriteLine("Your final bill before any discounts is: $" + totalAmount);
                Console.WriteLine("Your Final Bill after Discount: $" + fiveDiscount);
                Console.WriteLine("Congratualations! You have received a 5% discount on your bill. Thanks you for your patronage.");
            }

        }
    }
}
