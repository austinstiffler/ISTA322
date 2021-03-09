using System;

namespace ProgEx08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Exercise 08: Guess My Number Game");

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Part 1: Computer picks a number between 1 - 1000.");
            Console.WriteLine("Guess the number, human! You get 10 guesses to be correct.");


            Random rNum = new Random();
            int rn = rNum.Next(1, 1000);

            static int humanGuess()
            {
                int myGuess = 0;
                try
                {
                    myGuess = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter an integer");
                    myGuess = humanGuess();
                }
                return myGuess;
            }

            int maxGuesses = 10;
            int guesses = 0;

            while (true)
            {
                int guess = humanGuess();
                guesses++;
                if (guess == rn)
                {
                    Console.WriteLine("Your guess was correct!");
                    break;
                }
                if (guess > rn)
                {
                    Console.WriteLine("Your guess was too high");
                }
                if (guess < rn)
                {
                    Console.WriteLine("Your guess was too low");
                }
                if (guesses == maxGuesses)
                {
                    Console.WriteLine($"You lose. The number was: {rn}");
                    break;
                }
                Console.Write($"You have {maxGuesses - guesses} tries left. Enter another number: ");
            }

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Part 2: Human picks a number between 1 - 100.");
            Console.WriteLine("Guess the number, computer! You get 7 guesses to be correct.");

            int min = 0; 
            int max = 100;
            int middle = 50;
            string input;
            int response;
            int maxG = 7;
            int g = 0;

            Console.WriteLine($"Is your guess {middle}? (0) = Yes | (1) = Too high | (2) = Too low");
            input = Console.ReadLine();
            response = int.Parse(input);

            do
            {
                g += 1;
                if (response == 2)
                {
                    min = middle + 1;
                }
                else if (response == 1)
                {
                    max = middle - 1;
                }
                else if (response != 1 && response != 2 && response != 0)
                {
                    Console.WriteLine($"{response}");
                    Console.WriteLine("Please select a valid key (0, 1, or 2).");
                }
                else if (response == 0)
                {
                    Console.WriteLine("Computer wins!");
                    break;
                }
                middle = (min + max) / 2;
                Console.WriteLine($"Is your guess {middle}? (0) = Yes | (1) = Too high | (2) = Too low");

                Console.WriteLine($"Computer has {maxG - g} tries left.");

                input = Console.ReadLine();
                response = int.Parse(input);

            } while (g < maxG - 1 && response != 0);

            Console.WriteLine("Game over.");
        }
    }
}
