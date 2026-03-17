using System;
if (Console.ReadLine() == "call") new Friend().Call();
public class FriendBase { protected internal void SayHi() => Console.WriteLine("Hello from Friend"); }
public class Friend : FriendBase { public void Call() => SayHi(); }
