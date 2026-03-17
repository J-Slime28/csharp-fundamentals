using System;

class Program
{
    static void Main()
    {
        string line = Console.ReadLine();
        if (line == null) return;

        string[] items = line.Split(' ');
        if (items.Length < 2) return;

        int val1 = Convert.ToInt32(items[0]);
        int val2 = Convert.ToInt32(items[1]);

        PrintProduct(val1, val2);
    }

    static void PrintProduct(int n1, int n2)
    {
        int res = 0;
        for (int i = 0; i < n2; i++)
        {
            res = res + n1; // Multiplying by adding
        }
        Console.WriteLine("Product: " + res);
    }
}
