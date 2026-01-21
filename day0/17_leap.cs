using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        string input = Console.ReadLine();

        // Validate input
        if (!int.TryParse(input, out int year) || year <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer year.");
            return;
        }

        // Check leap year condition
        if (IsLeapYear(year))
        {
            Console.WriteLine("Leap year");
        }
        else
        {
            Console.WriteLine("Not a leap year");
        }
    }

    /// <summary>
    /// Determines if a given year is a leap year.
    /// </summary>
    static bool IsLeapYear(int year)
    {
        // Leap year if divisible by 4 but not by 100, unless divisible by 400
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
