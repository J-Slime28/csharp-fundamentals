using System;

class Program {
    static void CategorizeAge() {
        int age = int.Parse(Console.ReadLine());
        if (age <= 12) Console.WriteLine("Child");
        else if (age <= 19) Console.WriteLine("Teen");
        else if (age <= 59) Console.WriteLine("Adult");
        else Console.WriteLine("Senior");
    }

    static void Main() {
        CategorizeAge();
    }
}
