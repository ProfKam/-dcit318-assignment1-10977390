using System;

class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine("--- Grade Calculator ---");
        Console.Write("Enter your numerical grade (0-100): ");

        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
            }
            else
            {
                string letterGrade = grade switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F"
                };

                Console.WriteLine($"Your letter grade is: {letterGrade}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}