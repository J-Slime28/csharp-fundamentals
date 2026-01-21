using System;

class Program {
    static void SplitAndPrint() {
        string input = Console.ReadLine();
        string[] parts = input.Split(',');
        foreach (string p in parts)
            Console.WriteLine(p.Trim());
    }

    static void Main() {
        SplitAndPrint();
    }
}
