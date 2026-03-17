using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        if (text != null)
        {
            if (IsPalindrome(text)) Console.WriteLine("Palindrome");
            else Console.WriteLine("Not a palindrome");
        }
    }

    static bool IsPalindrome(string s)
    {
        string clean = "";
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                clean = clean + char.ToLower(c);
            }
        }

        string back = "";
        foreach (char c in clean)
        {
            back = c + back;
        }

        return clean == back;
    }
}
