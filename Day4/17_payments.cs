using System;
var i1 = Console.ReadLine().Split(); var i2 = Console.ReadLine().Split();
Pay(i1[0] == "credit" ? new CreditCard() : new Paypal(), decimal.Parse(i1[1]));
Pay(i2[0] == "paypal" ? new Paypal() : new CreditCard(), decimal.Parse(i2[1]));
void Pay(IPayment p, decimal a) => p.Pay(a);
public interface IPayment { void Pay(decimal a); }
public class CreditCard : IPayment { public void Pay(decimal a) => Console.WriteLine($"CreditCard paid {a:F2}"); }
public class Paypal : IPayment { public void Pay(decimal a) => Console.WriteLine($"Paypal paid {a:F2}"); }
