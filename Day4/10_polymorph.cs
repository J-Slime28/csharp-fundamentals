using System; using System.Collections.Generic;
var s = new List<Shape> { new Circle(2), new Rectangle(2, 5) };
foreach (var h in s) Console.WriteLine(h is Circle ? $"{h.Area():F4}" : $"{h.Area()}");
public abstract class Shape { public abstract double Area(); }
public class Circle : Shape {
    double r; public Circle(double r) => this.r = r;
    public override double Area() => Math.PI * r * r;
}
public class Rectangle : Shape {
    double w, h; public Rectangle(double w, double h) { this.w = w; this.h = h; }
    public override double Area() => w * h;
}
