using System;
Console.WriteLine(new Greeter().Greet(Console.ReadLine()));
public sealed class Greeter { public string Greet(string n) => $"Hello, {n}"; }
