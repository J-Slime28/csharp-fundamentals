using System;
var l1 = Console.ReadLine().Split(); var l2 = Console.ReadLine().Split();
Console.WriteLine($"Circle area: {new Circle(double.Parse(l1[1])).Area():F4}");
Console.WriteLine($"Rectangle area: {new Rectangle(double.Parse(l2[1]), double.Parse(l2[2])).Area()}");
public abstract class Shape { public abstract double Area(); }
public class Circle : Shape {
    double r; public Circle(double r) => this.r = r;
    public override double Area() => Math.PI * r * r;
}
public class Rectangle : Shape {
    double w, h; public Rectangle(double w, double h) { this.w = w; this.h = h; }
    public override double Area() => w * h;
}
