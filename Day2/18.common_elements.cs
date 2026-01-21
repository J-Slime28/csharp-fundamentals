using System;
using System.Linq;

class Program {
    static void FindCommonElements() {
        int[] arr1 = Console.ReadLine().Select(c => c - '0').ToArray();
        int[] arr2 = Console.ReadLine().Select(c => c - '0').ToArray();
        var common = arr1.Intersect(arr2);
        Console.WriteLine(string.Join("", common));
    }

    static void Main() {
        FindCommonElements();
    }
}
