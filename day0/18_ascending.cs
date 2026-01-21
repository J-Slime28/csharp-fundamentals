using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter space-separated integers:");

        string input = Console.ReadLine();

        // Validate empty input
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input. Please enter at least one integer.");
            return;
        }

        // Try parsing the integers
        string[] parts = input.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            if (!int.TryParse(parts[i], out numbers[i]))
            {
                Console.WriteLine($"Invalid number: '{parts[i]}'. Please enter integers only.");
                return;
            }
        }

        // Check if the array is in ascending order
        bool isAscending = true;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[i - 1])
            {
                isAscending = false;
                break;
            }
        }

        Console.WriteLine(isAscending ? "Ascending" : "Not ascending");
    }
}
