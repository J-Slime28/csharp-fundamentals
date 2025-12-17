using System;

class Program
{

    static void Main()
    {
        // Ask user for input 
        Console.WriteLine("Welcome to the factorial calculator");
        Console.WriteLine("Please enter a number");
        int userInput;
        userInput = Convert.ToInt32(Console.ReadLine());
        // We start at one
        long factorial = 1;
        
        // A For loop that starts from what user entered and goes down to 1
        // Each time, we multiply the current value of factorial by i
        for (int i = userInput; i >= 1; i--)
        {
            factorial *= i;
        }
        // Print the result
        Console.WriteLine(userInput + "! = " + factorial);
    }
}
