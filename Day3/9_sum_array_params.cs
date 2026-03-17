using System;

class Program
{
    static void Main()
    {
        string line = Console.ReadLine();
        if (string.IsNullOrEmpty(line)) return;

        string[] parts = line.Split(' ');
        int[] numbers = new int[parts.Length];
        int i = 0;
        while (i < parts.Length)
        {
            numbers[i] = int.Parse(parts[i]);
            i = i + 1;
        }

        Console.WriteLine("Sum: " + Sum(numbers));
    }

    static int Sum(int[] arr)
    {
        int total = 0;
        int idx = 0;
        while (idx < arr.Length)
        {
            total = total + arr[idx];
            idx = idx + 1;
        }
        return total;
    }
}
