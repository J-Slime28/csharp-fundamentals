using System;

class Program
{

    static void Main()
    {
        // Let user enter an integer
        Console.WriteLine("Please enter a number");
        int num;
        num = Convert.ToInt32(Console.ReadLine());

        // Check if number is even(divisible by two)
        if (num % 2 == 0)
        {
            Console.WriteLine("This is an even number");
        }
        // If number is not divisible by two
        else
        {
            Console.WriteLine("This is an odd number");
        }
    }
}
