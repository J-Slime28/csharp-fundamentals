using System;

class Program
{
    // Method to calculate the sum of digits
    static int SumOfDigits(int number)
    {
        number = Math.Abs(number); // Handle negative numbers
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10; // Get last digit
            number /= 10;       // Remove last digit
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();

        // Validate input
        if (!int.TryParse(input, out int num))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        int result = SumOfDigits(num);
        Console.WriteLine($"The sum of digits of {num} is: {result}");
    }
}
