using System;
try { var p = new Person(int.Parse(Console.ReadLine())); Console.WriteLine($"Age set to {p.Age}"); }
catch (Exception e) { Console.WriteLine(e.Message); }
public class Person {
    int a; public int Age { get => a; set => a = value < 0 ? throw new ArgumentOutOfRangeException() : value; }
    public Person(int age) => Age = age;
}
