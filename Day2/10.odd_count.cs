using System;
using System.Linq;

class Program {
    static void CountOddNumbers() {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(arr.Count(x => x % 2 != 0));
    }

    static void Main() {
        CountOddNumbers();
    }
}
