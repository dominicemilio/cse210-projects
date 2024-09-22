using System;

class Program
{
    static void Main(string[] args)
    {
        // This makes a random number
        Random random = new Random();

        // Generate a random number between 1 and 100
        byte magicNumber = (byte)random.Next(1, 101);

        // Initialize user guess as integer
        byte guess;

        // Continue until the right number is guessed
        do
        {
            // Get the guess
            Console.Write("What's your guess? ");
            guess = byte.Parse(Console.ReadLine());

            // This checks if guess is low
            if (guess < magicNumber)
                Console.WriteLine("Higher");

            // This checks if guess is high
            else if (guess > magicNumber)
                Console.WriteLine("Lower");

            // If correct congratulate them
            else
                Console.WriteLine("You've got the number! the number is " + magicNumber);
        } while (guess != magicNumber);
    }
}