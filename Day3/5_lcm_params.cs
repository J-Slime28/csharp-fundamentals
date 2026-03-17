using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == null) return;

        string[] parts = input.Split(' ');
        if (parts.Length < 2) return;

        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);

        Console.WriteLine(Lcm(a, b));
    }

    static int Lcm(int x, int y)
    {
        if (x == 0 || y == 0) return 0;
        
        int max = x;
        if (y > x) max = y;
        
        int candidate = max;
        while (true)
        {
            if (candidate % x == 0 && candidate % y == 0)
            {
                return candidate;
            }
            candidate = candidate + 1;
        }
    }
}
