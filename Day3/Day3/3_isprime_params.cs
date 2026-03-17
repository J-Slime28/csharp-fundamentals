using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == null) return;

        int number = int.Parse(input);
        if (IsPrime(number)) Console.WriteLine("Prime");
        else Console.WriteLine("Not prime");
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        
        int divisor = 2;
        while (divisor < n)
        {
            if (n % divisor == 0) return false;
            divisor = divisor + 1;
        }
        return true;
    }
}
