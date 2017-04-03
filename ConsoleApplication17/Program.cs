using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1

            Console.WriteLine("Welcome to your future! Answer the following questions to begin.");
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            firstName = firstName.ToUpper();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            lastName = lastName.ToUpper();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your numeric birth month?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your ROYGBIV color? If you don't know what ROYGBIV is please type \"HELP\"");
            string color = Console.ReadLine();
            color = color.ToUpper();

            if (color == "HELP")
            {
                Console.WriteLine("R is Red, O is Orange, Y is Yellow,  G is Green, I is Indigo, and V is Violet. \t\nWhat is your favorite ROYGBIV color?");
                string color2 = Console.ReadLine();
            }

            Console.WriteLine("How many siblings do you have? Please type numbers only.");
            int sibs = int.Parse(Console.ReadLine());

            //Part 2

            //Retirement conditions
            int x = 2;
            if (age % x == 0)

                age = 30;

            else
                age = 40;

            //Bank account conditions
            if (birthMonth >= 1 && birthMonth <= 4)

                birthMonth = 200;

            else if (birthMonth >= 5 && birthMonth <= 8)

                birthMonth = 2000;

            if (birthMonth >= 9 && birthMonth <= 12)

                birthMonth = 20000;

            //Vacation home condition

            if (sibs == 0)
            {
                string sibs2 = "Florida";
            }
            else
            {
                Console.WriteLine("Cleveland");
            }

            Console.WriteLine("Your fortune is below!");
            string Fortune = (firstName + " " + lastName + " will retire in " + age + " years with " + birthMonth +
                " dollars in the bank, \n a vacation home in " + sibs + " and a " + color + " for transportation");
            Console.WriteLine(Fortune);
        }
    }
}
