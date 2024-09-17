using System;

class Program
{
    // Main is the starting point of the program
    static void Main(string[] args)
    {
        // Ask user for their grade
        Console.Write("Please enter your grade as a percentage (0-100): ");
        
        // Read the input 
        int grade = int.Parse(Console.ReadLine());

        // Check the correct grade and print it
        if (grade >= 90)
        {
            Console.WriteLine("Your grade is an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is a C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is a D");
        }
        else
        {
            Console.WriteLine("Your grade is an F");
        }
        

    }

}