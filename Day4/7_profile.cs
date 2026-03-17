using System;
var i = Console.ReadLine().Split(); var p = new Profile(i[0], i[1]);
Console.WriteLine($"Username: {p.Username}\nEmail: {p.GetEmail()}");
public class Profile {
    public string Username { get; set; }
    string e;
    public Profile(string u, string email) { Username = u; e = email; }
    public string GetEmail() => e;
}
