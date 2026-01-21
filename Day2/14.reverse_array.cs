using System;
using System.Linq;

class Program {
    static void ReverseArray() {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Reverse(arr);
        Console.WriteLine(string.Join(" ", arr));
    }

    static void Main() {
        ReverseArray();
    }
}
