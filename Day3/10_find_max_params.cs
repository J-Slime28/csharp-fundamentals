using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return;

        string[] items = input.Split(' ');
        int[] arr = new int[items.Length];
        for (int i = 0; i < items.Length; i++) arr[i] = int.Parse(items[i]);

        Console.WriteLine("Max: " + FindMax(arr));
    }

    static int FindMax(int[] vals)
    {
        if (vals.Length == 0) return 0;
        
        int highest = -2147483648; // Smallest possible int
        int j = 0;
        while (j < vals.Length)
        {
            if (vals[j] > highest)
            {
                highest = vals[j];
            }
            j = j + 1;
        }
        return highest;
    }
}
