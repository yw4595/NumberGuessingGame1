using System;

namespace NumberGuessingGame
{
    /// <summary>
    /// Author: Yanzhi Wang
    /// Purpose: This class contains the main method that implements the number guessing game.
    /// Restrictions: None
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Keep track of the number of tries
            int tries = 0;

            // Generate a random number between 0 and 100 inclusive
            Random rand = new Random();
            int randomNumber = rand.Next(0, 101);

            // Loop for 8 tries
            while (tries < 8)
            {
                // Prompt the user to guess a number
                Console.Write("Guess a number between 0 and 100: ");
                string userInput = Console.ReadLine();

                // Parse the user input
                bool isValid = int.TryParse(userInput, out int guess);

                // Check if the user input is valid
                if (isValid && guess >= 0 && guess <= 100)
                {
                    // Check if the guess is correct
                    if (guess == randomNumber)
                    {
                        Console.WriteLine("Correct! You guessed it in " + (tries + 1) + " tries.");
                        break;
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Too low.");
                    }
                    else
                    {
                        Console.WriteLine("Too high.");
                    }

                    // Increment the number of tries
                    tries++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Guess should be between 0 and 100.");
                }
            }

            // If the player failed to guess the correct number
            if (tries == 8)
            {
                Console.WriteLine("You failed to guess the number. The number was " + randomNumber + ".");
            }
        }
    }
}
