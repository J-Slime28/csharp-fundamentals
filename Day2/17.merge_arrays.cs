using System;
using System.Linq;

class Program {
    static void MergeArrays() {
        int[] arr1 = Console.ReadLine().Select(c => c - '0').ToArray();
        int[] arr2 = Console.ReadLine().Select(c => c - '0').ToArray();
        Console.WriteLine(string.Join("", arr1.Concat(arr2)));
    }

    static void Main() {
        MergeArrays();
    }
}
