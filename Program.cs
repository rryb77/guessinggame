using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;

            Console.Write("Can you guess the secret number? ");
            string input = Console.ReadLine();
            int parsedInput = Int32.Parse(input);

            if (parsedInput == secretNumber)
            {
                Console.WriteLine($"Correct! It was {secretNumber}!");
            }
            else
            {
                Console.WriteLine($"Wrong! It was {secretNumber}!");
            }
        }
    }
}
