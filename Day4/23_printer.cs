using System;
var i1 = Console.ReadLine().Split(); var i2 = Console.ReadLine().Split();
var p = new Printer();
p.Print(new Document(i1[1])); p.Print(new Image(i2[1]));
public interface IPrintable { void Print(); }
public class Document : IPrintable { string n; public Document(string n) => this.n = n; public void Print() => Console.WriteLine($"Printing document: {n}"); }
public class Image : IPrintable { string n; public Image(string n) => this.n = n; public void Print() => Console.WriteLine($"Printing image: {n}"); }
public class Printer { public void Print(IPrintable p) => p.Print(); }
