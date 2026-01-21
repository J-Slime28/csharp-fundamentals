using System;
using System.Linq;

class Program {
    static void SumOddNumbers() {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(arr.Where(x => x % 2 != 0).Sum());
    }

    static void Main() {
        SumOddNumbers();
    }
}
