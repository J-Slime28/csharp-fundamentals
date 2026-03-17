using System;
var t1 = Console.ReadLine(); var t2 = Console.ReadLine();
Console.WriteLine(t1 == "car" ? new Car().Describe() : new Truck().Describe());
Console.WriteLine(t2 == "truck" ? new Truck().Describe() : new Car().Describe());
public class Vehicle { public virtual string Describe() => "Vehicle"; }
public class Car : Vehicle { public override string Describe() => "Car: I am a car"; }
public class Truck : Vehicle { public override string Describe() => "Truck: I am a truck"; }
