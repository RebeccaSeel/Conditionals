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
            /*//ask user for number of diners in their party
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
             
            }*/

            /*int age;

            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            if (age > 0 && age <= 2)
            {
                Console.WriteLine("Still in Mama's Arms");
            }
            else if (age >= 3 && age <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (age >= 5 && age <= 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (age >= 12 && age <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (age >= 15 && age <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (age >= 19 && age <= 22)
            {
                Console.WriteLine("College");
            }
            else if (age >= 23 && age <= 65)
            {
                Console.WriteLine("Working for the Man");
            }
            else if (age >= 66 && age <= 100)
            {
                Console.WriteLine("The Golden Years");
            }
            else           {
                Console.WriteLine("This Program is for Humnans");
          }
        */

            Console.WriteLine("Type a number between 1 and 10 in word form");

            string word = Console.ReadLine();
            switch (word)
            {
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("Error: please enter another number between 1 and 10 in word form");
                    break;
           }


        }
    }
}
