using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        if (s != null)
        {
            int n = int.Parse(s);
            Console.WriteLine(Fib(n));
        }
    }

    static int Fib(int n)
    {
        if (n <= 0) return 0;
        
        int[] history = new int[n + 1];
        history[0] = 0;
        if (n >= 1) history[1] = 1;

        int i = 2;
        while (i <= n)
        {
            history[i] = history[i - 1] + history[i - 2];
            i = i + 1;
        }
        return history[n];
    }
}
