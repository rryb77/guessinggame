﻿using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);
            int totalGuesses = 0;
            bool winner = false;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("| Choose Your Difficulty         |");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("| 1. Easy                        |");
            Console.WriteLine("| 2. Medium                      |");
            Console.WriteLine("| 3. Hard                        |");
            Console.WriteLine("| 4. Cheater                     |");
            Console.WriteLine("----------------------------------");

            string difficulty = Console.ReadLine();
            int parsedDifficulty = Int32.Parse(difficulty);

            if (parsedDifficulty == 1)
            {
                totalGuesses = 8;
            }
            else if (parsedDifficulty == 2)
            {
                totalGuesses = 6;
            }
            else if (parsedDifficulty == 3)
            {
                totalGuesses = 4;
            }

            Console.WriteLine("Can you guess the secret number? ");

            if (parsedDifficulty <= 3)
            {
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
                            Console.WriteLine($"Wrong! Try lower...");
                        }
                        else
                        {
                            Console.WriteLine($"Wrong! Try higher...");
                        }
                    }

                    totalGuesses--;
                    Console.WriteLine("");
                }
            }
            else
            {
                while (winner == false)
                {

                    Console.Write($"Your Guess (∞): ");
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
                            Console.WriteLine($"Wrong! Try lower...");
                        }
                        else
                        {
                            Console.WriteLine($"Wrong! Try higher...");
                        }
                    }

                    Console.WriteLine("");
                }
            }
        }
    }
}
