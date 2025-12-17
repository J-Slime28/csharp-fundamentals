using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Which number would you like to check ?");
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        // Check divisibility
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        // Output result
        if (isPrime)
        {
            Console.WriteLine("Prime number");
        }
        else
        {
            Console.WriteLine("Not a prime number");
        }
    }
}
