using System;

class Calculator
{
    static void Main()
    {
        try
        {
            // Read first number
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            // Read second number
            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            // Read operator
            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine()?.Trim();

            double result;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {result}");
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {result}");
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {result}");
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    result = num1 / num2;
                    Console.WriteLine($"Result: {result:F2}"); // Two decimal places
                    break;

                default:
                    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}
