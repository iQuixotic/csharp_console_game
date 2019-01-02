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
            getAppInfo();

            greetUser();

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
                        printColorMessage(ConsoleColor.Red, "That's not even a real number, you fool!!");

                        continue;
                    }

                    // Cast string to int
                    guess = Int32.Parse(input);

                    if (guess != correctNum)
                    {
                        printColorMessage(ConsoleColor.Red, "Guess again, fool!!");

                    }
                }

                // If user wins
                printColorMessage(ConsoleColor.Magenta, "You have won, you fool!!");

                // Play again
                Console.WriteLine("Would you like to play again? [y/n]");
                string answer = Console.ReadLine().ToUpper();
                if(answer == "Y") { continue; }
                else if(answer == "N") { return; }
            }
        }

        // Get and display app info
        static void getAppInfo()
        {

            // App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "iQuixotic";

            // Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Text Color
            Console.ResetColor();
        }

        // Greet
        static void greetUser()
        {
            // Get Name
            Console.WriteLine("What is your Name?");
            string inputName = Console.ReadLine();

            // Trap user in a game that he/she/they doesn't want to play
            // (I added they just for the rhyme...)
            Console.WriteLine("Cool {0}, let's play a game...", inputName);
        }

        // Print color message
        static void printColorMessage(ConsoleColor color, string message)
        {
            // Text Color
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            // Text Color
            Console.ResetColor();
        }
    }
}
