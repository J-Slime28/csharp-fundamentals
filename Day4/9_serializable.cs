using System;
var i = Console.ReadLine().Split();
Console.WriteLine(new Person(i[0], int.Parse(i[1])).Serialize());
public interface ISerializable { string Serialize(); }
public class Person : ISerializable {
    string n; int a;
    public Person(string n, int a) { this.n = n; this.a = a; }
    public string Serialize() => $"{{\"Name\":\"{n}\",\"Age\":{a}}}";
}
