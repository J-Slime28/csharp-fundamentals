using System;
var b = new BankAccount(decimal.Parse(Console.ReadLine()));
Console.WriteLine($"Balance: {b.GetBalance()}");
public class BankAccount {
    decimal b;
    public BankAccount(decimal i) => b = i;
    public decimal GetBalance() => b;
}
