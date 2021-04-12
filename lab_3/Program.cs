using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?");
            string userName = Console.ReadLine();

            bool repeat = true;
            string userResponse = "";

            while (repeat)
            {

                Console.WriteLine("Enter a whole number between 1 and 100:");
                string userInput = Console.ReadLine();
                int userNumber = int.Parse(userInput);

                    if (userNumber % 2 != 0)
                    {
                        Console.WriteLine($"{userName}, that number is...");
                        Console.WriteLine($"{userNumber} odd");
                    }
                    else if ((userNumber >= 2) && (userNumber <= 25) && (userNumber % 2 == 0))
                    {
                        Console.WriteLine($"{userName}, that number is...");
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if ((userNumber >= 26) && (userNumber <= 60) && (userNumber % 2 == 0))
                    {
                        Console.WriteLine($"{userName}, that number is...");
                        Console.WriteLine("Even.");
                    }
                    else if ((userNumber > 60) && (userNumber % 2 == 0))
                    {
                        Console.WriteLine($"{userName}, that number is...");
                        Console.WriteLine($"{userNumber} Even.");
                    }
                    else if ((userNumber > 60) && (userNumber % 2 != 0))
                    {
                        Console.WriteLine($"{userName}, that number is...");
                        Console.WriteLine($"{userNumber} Odd");
                    }

                Console.WriteLine("Would you like to continue? (y|n)");
                string userAnswer = Console.ReadLine();

                if (userAnswer == "y")
                {
                    repeat = true;
                }
                else if (userAnswer == "n")
                {
                    repeat = false;
                }


            }

            Console.WriteLine($"Goodbye, {userName}");


        }
    }
}
