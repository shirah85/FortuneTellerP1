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
            //asked q's and save data entered by user
            //converted all letters entered into capital letter

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
                color2 = color2.ToUpper();
            }

            Console.WriteLine("How many siblings do you have?");
            float sibs = float.Parse(Console.ReadLine());

            //Part 2
            //Retirement conditions
            //Retire in 30 or 40 years

            int x = 2;
            if (age % x == 0)

                age = 30;

            else
                age = 40;

            //Bank account conditions
            //account balance is based on birthMonth

            if (birthMonth >= 1 && birthMonth <= 4)

                birthMonth = 200;

            else if (birthMonth >= 5 && birthMonth <= 8)

                birthMonth = 2000;

            else if (birthMonth >= 9 && birthMonth <= 12)

                birthMonth = 20000;
            else

                birthMonth = 0;

            //Vacation home condition         
            //converted int to string

            string vHome = Convert.ToString(sibs);
            if (sibs == 0)
            {
                vHome = "Florida";
            }
            else if (sibs == 2)
            {
                vHome = "California";
            }
            else if (sibs == 3)
            {
                vHome = "The Hamptons";
            }
            else if (sibs > 3)
            {
                vHome = "Paris, France";
            }
            else
                vHome = "Cleveland, Ohio";


            //Transportation Type
            //color determines source of transportation

            switch (color)
            {
                case"RED":
                    color = "private jet"; 
                    break;

                case"ORANGE":
                    color = "boat";
                    break;

                case"YELLOW":
                    color = "bike";
                        break;

                case"Green":
                    color = "motorcycle";
                    break;

                case"BLUE":
                    color = "roller blades";
                    break;

                case"INDIGO":
                    color = "bus";
                    break;

                case"VIOLET":
                    color = "car";
                    break;

                case"HELP":
                    color = "skate board";
                    break;

                default:
                    color= "pair of tenis shoes";
                    break;

            }
            //Part 3
            //Final fortune is formated below

            Console.WriteLine("Your fortune is below!");
            string Fortune = (firstName + " " + lastName + " will retire in " + age + " years with $" + birthMonth +
                " in the bank, \n a vacation home in " + vHome + " and a " + color + " for transportation. Thank you for playing!");
            Console.WriteLine(Fortune);
        }
    }
}
