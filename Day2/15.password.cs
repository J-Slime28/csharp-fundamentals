using System;

class Program {
    static void ValidatePassword() {
        string pwd = Console.ReadLine();
        Console.WriteLine(pwd.Length >= 8 ? "Valid" : "Invalid");
    }

    static void Main() {
        ValidatePassword();
    }
}
