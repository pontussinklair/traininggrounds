using System;

namespace Calculator_FXSS1
{
    public class Program
    {
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        // exempel Addition([10,20,30])

        public static double Addition(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];

            }

            Console.WriteLine(sum);

            return sum;
        }
        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Not possible to divide with 0");// Skyddar mot division med noll
                Console.ResetColor();
            }
            return num1 / num2;  
            
        }
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi and welcome to the FXSS1 Mathematical Simulator!");
            Console.WriteLine(); // Empty line.
            Console.WriteLine("Please press any key to initialize the simulation");

            Console.ReadKey(true);    // Wait for input key to continue

            bool keepAlive = true;


            while (keepAlive)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Enter your first number:");
                    double num1 = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("What simulation would you like to execute?");


                    Console.WriteLine("/n A=Addition");

                    Console.WriteLine("/n S=Subtraction");

                    Console.WriteLine("/n M=Multiplication");

                    Console.WriteLine("/n D=Division");


                    char UserSelection = Console.ReadKey(true).KeyChar;


                    Console.Write("Enter your second number:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.ResetColor();
                    switch (UserSelection)
                    {
                        case 'a':
                        case 'A':
                            Console.WriteLine($"{num1} + {num2} = {Addition(num1,num2)}"); 
                           /* double[] myArray = { 10, 20, 30, 40 };
                            Addition(myArray);*/
                            break;
                        case 's':
                        case 'S':
                            Console.WriteLine($"{num1} - {num2} = {Subtraction(num1, num2)}");
                            break;
                        case 'm':
                        case 'M':
                            Console.WriteLine($"{num1} * {num2} = {Multiplication(num1, num2)}");
                            break;
                        case 'd':
                        case 'D':
                            Console.WriteLine($"{num1} / {num2} = {Division(num1, num2)}");
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning! You have presented an invalid input");
                            Console.ResetColor();

                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input, please try again?");

                }
            }
            // Gives the user a choice
            Console.WriteLine("Would you like to restart or quit the simulation\n Choose 'q' to quit, any other to continue?");

            if (char.Parse(Console.ReadLine().ToLower()) == 'q')
            {
                keepAlive = false;
            }
        }
    }

}








