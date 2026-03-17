using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input != null) Console.WriteLine(Reverse(input));
    }

    static string Reverse(string original)
    {
        string output = "";
        foreach (char c in original)
        {
            output = c + output; // Prepending to reverse
        }
        return output;
    }
}
