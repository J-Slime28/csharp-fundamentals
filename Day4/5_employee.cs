using System;
Console.WriteLine($"Role: {new Employee(Console.ReadLine()).GetRole()}");
public class PersonBase { protected string r; }
public class Employee : PersonBase {
    public Employee(string role) => r = role;
    public string GetRole() => r;
}
