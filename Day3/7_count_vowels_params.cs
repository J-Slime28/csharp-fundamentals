using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        if (text != null) Console.WriteLine(CountVowels(text));
    }

    static int CountVowels(string s)
    {
        int count = 0;
        foreach (char c in s)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                count = count + 1;
            }
        }
        return count;
    }
}
