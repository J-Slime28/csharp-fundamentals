using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        // Handle negative numbers by taking absolute value
        number = Math.Abs(number);

        // Special case: zero has 1 digit
        if (number == 0)
        {
            Console.WriteLine("Number of digits: 1");
            return;
        }

        // Count digits using division
        int count = 0;
        while (number > 0)
        {
            number /= 10;
            count++;
        }

        Console.WriteLine($"Number of digits: {count}");
    }
}
