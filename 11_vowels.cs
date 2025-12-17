using System;

class Program
{
    // Function to count vowels in a string
    static int CountVowels(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        int count = 0;
        string vowels = "aeiouAEIOU";

        foreach (char ch in input)
        {
            if (vowels.Contains(ch))
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        // Validate input
        if (string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("Invalid input. Please enter a non-empty string.");
            return;
        }

        int vowelCount = CountVowels(userInput);
        Console.WriteLine($"Number of vowels in the string: {vowelCount}");
    }
}
