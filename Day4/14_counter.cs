using System;
var c = new Counter(int.Parse(Console.ReadLine()));
while(true) {
    var cmd = Console.ReadLine();
    if (cmd == "increment") c.Increment();
    else if (cmd == "get") { Console.WriteLine(c.Get()); break; }
}
public class Counter {
    int v; public Counter(int s) => v = s;
    public void Increment() => v++; public void Decrement() => v--; public int Get() => v;
}
