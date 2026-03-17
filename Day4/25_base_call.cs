using System;
if (Console.ReadLine() == "describe") Console.WriteLine(new Derived().Describe());
public class Base { public virtual string Describe() => "Base"; }
public class Derived : Base { public override string Describe() => base.Describe() + "; Derived appended info"; }
