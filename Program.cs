using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);
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
                    if (parsedInput > secretNumber)
                    {
                        Console.WriteLine($"Wrong! It's lower... {secretNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"Wrong! It's higher... {secretNumber}");
                    }

                }

                totalGuesses--;
                Console.WriteLine("");
            }

        }
    }
}
