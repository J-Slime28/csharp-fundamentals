using System;

class Program {
    static void ExtractSubstring() {
        string input = Console.ReadLine();
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine(input.Substring(start, end - start));
    }

    static void Main() {
        ExtractSubstring();
    }
}
