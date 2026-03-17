using System;
Console.WriteLine($"Environment: {new Config(Console.ReadLine()).Environment}");
public class Config {
    public readonly string Environment;
    public Config(string e) => Environment = e;
}
