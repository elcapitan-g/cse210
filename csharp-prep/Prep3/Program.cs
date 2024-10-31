using System;

class Program
{static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your number guess? ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess))
            {
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Congratulations! You have guessed the number!");
                }
            }

        }
    }
}