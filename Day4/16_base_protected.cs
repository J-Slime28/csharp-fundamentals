using System;
Console.WriteLine(new Derived(Console.ReadLine()).Title);
public class Base {
    public string Title { get; }
    protected Base(string t) => Title = $"Report Title: {t}";
}
public class Derived : Base { public Derived(string t) : base(t) {} }
