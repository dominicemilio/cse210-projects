using System;

class Program
{
    // Main is the starting point
    static void Main(string[] args)
    {
        // Ask the user for their name and surname
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("What is your surname? ");
        string surname = Console.ReadLine();

        Console.WriteLine($"Your name is {surname}, {name} {surname}!");
    }
}