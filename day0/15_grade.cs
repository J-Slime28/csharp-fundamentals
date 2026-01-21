// This program reads a score (0–100) from the user and prints the corresponding grade

using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter your score (0-100): ");
        string input = Console.ReadLine();
        int score;

        // Validate input
        if (int.TryParse(input, out score) && score >= 0 && score <= 100)
        {
            string grade;

            // Determine grade based on score
            if (score >= 90)
                grade = "A";
            else if (score >= 80)
                grade = "B";
            else if (score >= 70)
                grade = "C";
            else if (score >= 60)
                grade = "D";
            else
                grade = "F";

            Console.WriteLine($"Your grade is: {grade}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }

        // Wait for user input before closing
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
