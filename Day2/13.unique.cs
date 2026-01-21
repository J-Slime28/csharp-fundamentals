using System;
using System.Linq;

class Program {
    static void PrintUniqueElements() {
        int[] arr = Console.ReadLine().Select(c => c - '0').ToArray();
        foreach (var num in arr.Distinct())
            Console.Write(num);
    }

    static void Main() {
        PrintUniqueElements();
    }
}
