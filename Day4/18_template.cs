using System;
new MyProcessor().Process(Console.ReadLine());
public abstract class Processor {
    public void Process(string i) => Console.WriteLine(Step(i));
    protected abstract string Step(string i);
}
public class MyProcessor : Processor { protected override string Step(string i) => $"Processed: {i}"; }
