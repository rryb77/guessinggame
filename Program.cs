using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            int totalGuesses = 4;
            bool winner = false;

            Console.WriteLine("Can you guess the secret number? ");

            while (totalGuesses > 0 && winner == false)
            {

                Console.Write($"Your Guess ({totalGuesses}): ");
                string input = Console.ReadLine();
                int parsedInput = Int32.Parse(input);

                if (parsedInput == secretNumber)
                {
                    Console.WriteLine($"Correct! It was {secretNumber}!");
                    winner = true;
                }
                else
                {
                    Console.WriteLine($"Wrong! Try again!");
                }

                totalGuesses--;
                Console.WriteLine("");
            }

        }
    }
}
