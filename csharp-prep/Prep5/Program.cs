using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome the user
        DisplayWelcome();

        // Ask user's name and store variable
        string userName = PromptUserName();
        // Ask for their favorite number
        int userNumber = PromptUserNumber();
        // Determine the square of their number and store variable
        int squaredNumber = SquareNumber(userNumber);
        // Print their name and number squared on the display
        DisplayResult(userName, squaredNumber);      
    }
    // Welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        // Ask their name and return
        Console.WriteLine("What's your name? ");      
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        // Ask their favorite number and return
        Console.WriteLine("What's your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        // Determine the square of their number and return
        int squared = number * number;
        return squared;    
    }

    static void DisplayResult(string name, int squared)
    {
        // Show their name and their number squared
        Console.WriteLine($" {name}, your number squared is {squared}");
    }
    
}