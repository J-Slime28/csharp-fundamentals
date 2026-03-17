using System;
new ConsoleLogger().Log(Console.ReadLine());
public abstract class Logger { public abstract void Log(string m); }
public class ConsoleLogger : Logger { public override void Log(string m) => Console.WriteLine(m); }
