using System;
using System.Collections.Generic;
using System.Text;


namespace Övningsuppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");

            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit: ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;

                        case 2:
                            RunExerciseTwo();
                            break;

                        case 3:
                            RunExerciseThree();
                            break;

                        case 4:
                            RunExcerciseFour();
                            break;
                        case 5:
                            RunExcerciseFive();
                            break;
                        case 6:
                            RunExcerciseSix();
                            break;

                        case -1:
                            keepAlive = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number");
                    Console.ResetColor();

                }

            }

        }

        private static void RunExerciseOne()
        {
            string firstName = "Pontus";
            string lastName = "Eriksson";


            Console.WriteLine("You successfully ran exercise one!");
            Console.WriteLine($"Hello, {firstName} {lastName}! I’m glad to inform you that you are the test subject of my very first assignment!");
        }

        private static void RunExerciseTwo()
        {
            Console.WriteLine("Todays date is:" + DateTime.Now);
            Console.WriteLine("Tomorrows date is" + DateTime.Now.AddDays(1));
            Console.WriteLine("Yesterdays date is" + DateTime.Now.AddDays(-1));

            Console.WriteLine("You successfully ran exercise two!");
        }
        private static void RunExerciseThree()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(firstName + " " + lastName);
        }
        private static void RunExcerciseFour()
        {

            // return: “The brown fox jumped over the lazy dog”
            String str = "The quick fox Jumped Over the DOG";
            String newWord = str.ToLower(); //Why do i need to like Björn did write out like this to define something to newWord?
            str = str.Replace ("quick, brown"); ///Whats up with Replace here?
            newWord = newWord.Insert(30, "lazy");
            newWord = char.ToUpper(newWord[0]) + newWord[1..];
            Console.WriteLine(newWord);
        }
        private static void RunExcerciseFive()
        {
            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            String ret = str[str.IndexOf('[')..];
            ret = ret.Substring(0, 2) + ret[6..];
            ret = ret[0..^1];
            ret += ",6,7,8,9,10]";
            Console.WriteLine(ret);
        }
        private static void RunExcerciseSix()
        {
            Console.Write("Write a wholenumber (no decimals): ");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write another wholenumber (no decimals this time either...): ");
            int secondInt = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(firstInt, secondInt);
            int min = Math.Min(firstInt, secondInt);
            Console.WriteLine("The biggest number is: " + max);
            Console.WriteLine($"The smallest number is: {min} ");
            Console.WriteLine($"The diffrence is :  { max - min}");
            Console.WriteLine($"The sum is :  { max + min}");
            Console.WriteLine($"The product is :  { max * min}");
            Console.WriteLine($"The ratio is :  { max / min}");
        }
        private static void RunExcerciseSix()
        {
            Console.Write("Write a wholenumber (no decimals): ");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write another wholenumber (no decimals this time either...): ");
            int secondInt = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(firstInt, secondInt);
            int min = Math.Min(firstInt, secondInt);
            Console.WriteLine("The biggest number is: " + max);
            Console.WriteLine($"The smallest number is: {min} ");
            Console.WriteLine($"The diffrence is :  { max - min}");
            Console.WriteLine($"The sum is :  { max + min}");
            Console.WriteLine($"The product is :  { max * min}");
            Console.WriteLine($"The ratio is :  { max / min}");
        }
    }

}