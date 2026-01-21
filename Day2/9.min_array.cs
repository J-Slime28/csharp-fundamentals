using System;
using System.Linq;

class Program {
    static void FindMinInArray() {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(arr.Min());
    }

    static void Main() {
        FindMinInArray();
    }
}
