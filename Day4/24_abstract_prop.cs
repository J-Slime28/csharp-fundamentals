using System;
if (Console.ReadLine() == "create Dog") Console.WriteLine($"Sound: {new Dog().Sound}");
public abstract class Animal { public abstract string Sound { get; } }
public class Dog : Animal { public override string Sound => "Bark"; }
