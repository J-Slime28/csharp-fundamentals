using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == null) return;

        string[] parts = input.Split(' ');
        if (parts.Length < 2) return;

        int val1 = int.Parse(parts[0]);
        int val2 = int.Parse(parts[1]);

        Console.WriteLine(Gcd(val1, val2));
    }

    static int Gcd(int a, int b)
    {
        while (a != b)
        {
            if (a > b) a = a - b;
            else b = b - a;
        }
        return a;
    }
}
