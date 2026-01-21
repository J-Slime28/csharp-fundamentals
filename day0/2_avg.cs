using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("Hi, we are going to calculate the average of any 3 numbers of your choice!");

        // User input and input storage
        Console.WriteLine("Please enter your first number ?");
        double firstNum;
        firstNum = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter your second number ?");
        double secondNum;
        secondNum = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter your third number ?");
        double thirdNum;
        thirdNum = Convert.ToDouble(Console.ReadLine());

        // Average of all three numbers
        double avg;
        avg = (firstNum + secondNum + thirdNum) / 3 ;
        Console.WriteLine("Average: {0:F2} ", avg);
    }
}
