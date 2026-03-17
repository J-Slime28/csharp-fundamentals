using System;
var d = new Dual(); ((IA)d).Do(); ((IB)d).Do();
public interface IA { void Do(); }
public interface IB { void Do(); }
public class Dual : IA, IB {
    void IA.Do() => Console.WriteLine("(IA)dual -> IA.Do() output");
    void IB.Do() => Console.WriteLine("(IB)dual -> IB.Do() output");
}
