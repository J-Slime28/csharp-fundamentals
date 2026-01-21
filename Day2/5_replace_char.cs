using System;

class Program {
    static void ReplaceCharacter() {
        string input = Console.ReadLine();
        char oldChar = Console.ReadLine()[0];
        char newChar = Console.ReadLine()[0];
        Console.WriteLine(input.Replace(oldChar, newChar));
    }

    static void Main() {
        ReplaceCharacter();
    }
}
