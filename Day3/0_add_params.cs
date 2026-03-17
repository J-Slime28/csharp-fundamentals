using System;

class Program
{
    static void Main()
    {
        string raw = Console.ReadLine();
        if (raw == null) return;
        
        string[] split = raw.Split(' ');
        if (split.Length < 2) return;

        int num1 = Convert.ToInt32(split[0]);
        int num2 = Convert.ToInt32(split[1]);

        Console.WriteLine("Sum: " + Add(num1, num2));
    }

    static int Add(int x, int y)
    {
        int sum = x + y;
        return sum;
    }
}
