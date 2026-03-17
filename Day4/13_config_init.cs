using System;
var i = Console.ReadLine().Split(' ', '=');
var a = new AppInfo { Name = i[1], Version = int.Parse(i[3]) };
Console.WriteLine($"{a.Name} v{a.Version}");
public class AppInfo { public string Name { get; init; } public int Version { get; init; } }
