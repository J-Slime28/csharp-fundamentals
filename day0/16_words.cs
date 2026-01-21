using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a line of text: ");
        string input = Console.ReadLine();

        // Validate input
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Number of words: 0");
            return;
        }

        // Split by spaces, remove empty entries caused by multiple spaces
        string[] words = input.Split(
            new char[] { ' ' }, 
            StringSplitOptions.RemoveEmptyEntries
        );

        Console.WriteLine("Number of words: " + words.Length);
    }
}
