using System;
var i = Console.ReadLine().Split();
Console.WriteLine(i.Length > 1 ? new Point(int.Parse(i[0]), int.Parse(i[1])) : new Point());
public class Point {
    int x, y;
    public Point() : this(0, 0) {}
    public Point(int x, int y) { this.x = x; this.y = y; }
    public override string ToString() => $"X={x}, Y={y}";
}
