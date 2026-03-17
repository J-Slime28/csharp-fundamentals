using System;
var i1 = Console.ReadLine().Split(); var i2 = Console.ReadLine().Split();
var m = new MathOps();
Console.WriteLine(m.Add(int.Parse(i1[1]), int.Parse(i1[2])));
Console.WriteLine(m.Add(double.Parse(i2[1]), double.Parse(i2[2])).ToString("F1"));
public class MathOps {
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
}
