using System;

class Program {
    static void PrintFactorialSeries() {
        int n = int.Parse(Console.ReadLine());
        long fact = 1;
        for (int i = 1; i <= n; i++) {
            fact *= i;
            Console.WriteLine($"{i}! = {fact}");
        }
    }

    static void Main() {
        PrintFactorialSeries();
    }
}
