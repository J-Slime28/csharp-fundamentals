using System;
using System.Linq;

class Program {
    static void ArrayDifference() {
        int[] arr1 = Console.ReadLine().Select(c => c - '0').ToArray();
        int[] arr2 = Console.ReadLine().Select(c => c - '0').ToArray();
        var diff = arr1.Except(arr2);
        Console.WriteLine(string.Join("", diff));
    }

    static void Main() {
        ArrayDifference();
    }
}
