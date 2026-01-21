using System;

class Program
{

    static void Main()
    {
        // Ask user for temp (in Fahrenheit)
        Console.WriteLine("Hello, what is the current temperature ?");
        double tempInF;
        tempInF = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Thank you, now this will be converted from Fahrenheit to Celsius.");
        Console.Beep();

        double tempInC;
        // Conversion from Fahrenheit to Celsius using C = (F - 32) * 5 / 9
        tempInC = (tempInF - 32) * 5/9;
        
        // Result
        Console.WriteLine("Here is the temperature in degrees Celsius");
        Console.WriteLine("Celsuius: {0:F1}", tempInC);

    }
}
