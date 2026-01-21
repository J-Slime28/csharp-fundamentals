using System;

class Program {
    static void CheckStringContains() {
        string input = Console.ReadLine();
        string sub = Console.ReadLine();
        if (input.Contains(sub))
            Console.WriteLine("Found");
        else
            Console.WriteLine("Not found");
    }

    static void Main() {
        CheckStringContains();
    }
}
