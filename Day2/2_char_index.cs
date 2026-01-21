using System;

class Program {
    static void GetCharacterAtIndex() {
        string input = Console.ReadLine();
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine(input[index]);
    }

    static void Main() {
        GetCharacterAtIndex();
    }
}
