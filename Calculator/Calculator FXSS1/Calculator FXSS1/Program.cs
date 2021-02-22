using System;

namespace Calculator_FXSS1
{
    class Program
    {
        static void Main(string[] args)

        {


            {
                bool backTop = true;

                while (backTop);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi and welcome to the FXSS1 Mathematical Simulator!");
            Console.WriteLine("Please press any key to initialize the simulation");

            Console.ReadKey(true);    // Wait for input key to continue
            {
                Console.WriteLine("What simulation would you like to execute?");
                Console.WriteLine(); // Empty line.
                Console.WriteLine("A=Addition");
                Console.WriteLine(); // Empty line.
                Console.WriteLine("S=Subtraction");
                Console.WriteLine(); // Empty line.
                Console.WriteLine("M=Multiplication");
                Console.WriteLine(); // Empty line.
                Console.WriteLine("D=Division");

                char UserSelection = Console.ReadKey(true).KeyChar;

                switch (UserSelection)
                {

                    // If user enter A
                    case 'A':
                    case 'a':

                        Console.Write("Please enter the first number:");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter the second number:");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        Addition(num1, num2);
                        break;

                    // If user enter S  
                    case 'S':
                    case 's':

                        Console.Write("Please enter the first number:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter the second number:");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Subtraction(num1, num2);
                        break;

                    // If user enter M 
                    case 'M':
                    case 'm':

                        Console.Write("Please enter the first number:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter the second number:");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Multiplication(num1, num2);
                        break;

                    // If user enter D 
                    case 'D':
                    case 'd':

                        Console.Write("Please enter the first number:");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter the second number:");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Division(num1, num2);
                        break;

                    // Om annat än 1, 2, 3 or 4 anges visas felmeddelande
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Warning! You have presented an invalid input");
                        Console.ResetColor();

                        break;
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Would you like to restart the simulation press 'm' or type 'stop' to exit.");


                string input = "m";


                    while (input != "stop")
                {
                    input = Console.ReadLine();
                    Console.WriteLine("> Invalid input" + input.ToUpper());
                }

                Console.WriteLine("> Goodbye!");



            }
            static void Addition(double num1, double num2)
            {
                Console.WriteLine(num1 + num2);
            }
            static void Subtraction(double num1, double num2)
            {
                Console.WriteLine(num1 - num2);
            }
            static void Multiplication(double num1, double num2)
            {
                Console.WriteLine(num1 * num2);
            }
            static void Division(double num1, double num2)
            {

                if (num2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not possible to divide with 0");
                    Console.ResetColor();
                }

                else
                {
                    Console.WriteLine(num1 / num2);
                }


            }

        }

    }

}






