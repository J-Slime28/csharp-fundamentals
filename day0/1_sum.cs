using System;

class Program
{

    static void Main()
    {
        // User input and input storage
        Console.WriteLine("Please enter a number");
        int num1 ;
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter another number");
        int num2 ;
        num2 = Convert.ToInt32(Console.ReadLine());

        // Display numbers
        Console.WriteLine("Here are the numbers you entered: ");
        Console.WriteLine(num1);
        Console.WriteLine(num2);

        // sum of both numbers
        int sum;
        sum = num1 + num2;
        
        // Display sum
        Console.WriteLine("Sum: " + sum);
    }
}
