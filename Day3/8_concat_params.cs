using System;

class Program
{
    static void Main()
    {
        string list = Console.ReadLine();
        string s = Console.ReadLine();
        if (list != null && s != null) 
        {
            string[] items = list.Split(',');
            Console.WriteLine(Join(items, s));
        }
    }

    static string Join(string[] words, string separator)
    {
        string final = "";
        for (int i = 0; i < words.Length; i++)
        {
            final = final + words[i];
            if (i < words.Length - 1)
            {
                final = final + separator;
            }
        }
        return final;
    }
}
