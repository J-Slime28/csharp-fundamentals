using System; using System.Collections.Generic;
IEnumerable<object> o = new List<string> { "example string" };
foreach (var s in o) Console.WriteLine($"Produced: {s}");
