using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        
        // Try to parse the input safely
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        // Print multiplication table from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}
