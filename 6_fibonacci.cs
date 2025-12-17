using System;

class Program
{

    static void Main()
    {
        // Read how many Fibonacci numbers to print and get user input
        Console.WriteLine("Please enter a number");
        int userNum;
        userNum = Convert.ToInt32(Console.ReadLine());

        // First two Fibonacci numbers
        int first;
        first = 0;
        int second;
        second = 1;

        // Loop n times to print n numbers
        for (int i = 0; i < userNum; i++)
        {
            // Print the current number
            Console.Write(first);

            // Print a space after each number except the last
            if (i < userNum - 1)
            {
                Console.Write(" ");
            }

            // Calculate the next Fibonacci number
            int next = first + second;

            // Move the numbers forward
            first = second;
            second = next;
        }
    }
}
