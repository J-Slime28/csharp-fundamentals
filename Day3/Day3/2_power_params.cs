using System;

class Program
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        if (s1 == null || s2 == null) return;

        double b = double.Parse(s1);
        int e = int.Parse(s2);

        Console.WriteLine(Power(b, e));
    }

    static double Power(double baseValue, int exponentValue)
    {
        double result = 1.0;
        int count = 0;
        while (count < exponentValue)
        {
            result = result * baseValue;
            count = count + 1;
        }
        return result;
    }
}
