using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int highScore = int.MaxValue;
        string playerName = "";
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("Select Difficulty Level:");
            Console.WriteLine("1. Easy (10 guesses)");
            Console.WriteLine("2. Medium (7 guesses)");
            Console.WriteLine("3. Hard (5 guesses)");
            Console.Write("Enter your choice (1, 2, or 3): ");
            string difficultyInput = Console.ReadLine();

            int maxGuesses;
            switch (difficultyInput)
            {
                case "1":
                    maxGuesses = 10;
                    break;
                case "2":
                    maxGuesses = 7;
                    break;
                case "3":
                    maxGuesses = 5;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Easy level.");
                    maxGuesses = 10;
                    break;
            }

            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int userGuess = 0;
            int numberOfGuesses = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine($"You have {maxGuesses} guesses. Can you guess what it is?");

            while (userGuess != numberToGuess && numberOfGuesses < maxGuesses)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userGuess))
                {
                    numberOfGuesses++;

                    if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {numberOfGuesses} tries.");
                        if (numberOfGuesses < highScore)
                        {
                            highScore = numberOfGuesses;
                            Console.Write("New high score! Enter your name: ");
                            playerName = Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            if (userGuess != numberToGuess)
            {
                Console.WriteLine($"Sorry, you've used all {maxGuesses} guesses. The number was {numberToGuess}.");
            }

            Console.WriteLine($"High Score: {highScore} by {playerName}");
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower() == "yes";
        }
    }
}
