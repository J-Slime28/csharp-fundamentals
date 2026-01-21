using System;
class Program
{
   static void Main()
   {
       string original = "Hello, World!";
       char[] charArray = original.ToCharArray();
       Array.Reverse(charArray);
       string reversed = new string(charArray);
       Console.WriteLine(reversed); // Output: !dlroW ,olleH
   }
}
