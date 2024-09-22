using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber;

        // I'll use a do-while loop
        do
        {
            Console.Write("Enter a whole number or 0 to quit): ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Add any number that is not 0 to the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        while (userNumber != 0);

        // Add them all up
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Get the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Determine the largest number
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The max is: {largest}");
    }
}