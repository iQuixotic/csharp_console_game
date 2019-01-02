using System;

// Namespace
namespace consoleGame
{
    // Main Class
    class Program
    {
        // Entry Point
        static void Main(string[] args)
        {
            // App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "iQuixotic";
            string wrongNum = "That guess is incorrect. Please guess another number in between 0 and 10";

            // Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);


            // Text Color
            Console.ResetColor();

            // Get Name
            Console.WriteLine("What is your Name?");
            string inputName = Console.ReadLine();

            Console.WriteLine("Cool {0}, let's play a game...", inputName);

            while (true)
            {
                // Init correct Num
                Random random = new Random();
                int correctNum = random.Next(1, 10);


                // Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNum)
                {
                    // Get input
                    string input = Console.ReadLine();

                    // Is guess a number?
                    if (!int.TryParse(input, out guess))
                    {
                        // Text Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("That's not even a real number, you fool!!");

                        // Text Color
                        Console.ResetColor();

                        continue;
                    }

                    // Cast string to int
                    guess = Int32.Parse(input);

                    if (guess != correctNum)
                    {
                        // Text Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Guess again fool!!");

                        // Text Color
                        Console.ResetColor();

                    }
                }

                // If user wins
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("You are correct now");

                // Text Color
                Console.ResetColor();

                // Play again
                Console.WriteLine("Would you like to play again? [y/n]");
                string answer = Console.ReadLine().ToUpper();
                if(answer == "Y") { continue; }
                else if(answer == "N") { return; }
            }
        }
    }
}
