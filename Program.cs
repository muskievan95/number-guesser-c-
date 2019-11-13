using System;

// Namespace
namespace numberguesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuther = "Evan Myllenbeck";


            // Change text color

            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info



            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuther);

            // Reset text color
            Console.ResetColor();


            // Ask users name

            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game..", inputName);

            // Init correct number

            int correctNumber = 7;

            // Init guess var
            int guess = 0;

            // Ask user for #
            Console.WriteLine("Guess a number between 1 and 10");

            //guess not correct
            while (guess != correctNumber) ;

            // Make sure its a number
              if(!int.TryParse(input, out guess)) { 
                
            {
                // Get usesrs input
                string input = Console.ReadLine();

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // MAtch guess to correct number
                if (guess != correctNumber)
                {

                    // Change text color

                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user its the wrong number



                    Console.WriteLine("Wrong number, please try again");

                    // Reset text color
                    Console.ResetColor();


                }
            } // Change text color

            Console.ForegroundColor = ConsoleColor.Yellow;

            // Tell user its the right number



            Console.WriteLine("You are CORRECT!!");

            // Reset text color
            Console.ResetColor();
        }

    }
}
        