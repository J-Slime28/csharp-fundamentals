using System;
var input = Console.ReadLine().Split();
Console.WriteLine(new Person(input[0], int.Parse(input[1])));
public class Person {
    string n; int a;
    public Person(string name, int age) { n = name; a = age; }
    public override string ToString() => $"Name: {n}, Age: {a}";
}
