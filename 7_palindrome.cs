using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a word you'd like to check if its a palindrom or not");
        // Input string
        string input;
        input = Console.ReadLine();

        // Convert to lowercase and remove spaces
        string cleaned = input.ToLower().Replace(" ", "");

        // Convert string to char array and reverse it
        char[] chars = cleaned.ToCharArray();
        Array.Reverse(chars);
        string reversed = new string(chars);

        // Compare cleaned string with reversed version
        if (cleaned == reversed)
        {
            Console.WriteLine("This word is a Palindrome");
        }
        else
        {
            Console.WriteLine("This word is not a palindrome");
        }
    }
}
