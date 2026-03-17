using System;
Console.WriteLine(IdGenerator.Generate());
public class IdGenerator {
    static int n;
    static IdGenerator() => n = 1000;
    public static int Generate() => n++;
}
