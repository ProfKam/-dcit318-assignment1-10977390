using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("--- Triangle Type Identifier ---");

        double[] sides = new double[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter side {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out sides[i]) || sides[i] <= 0)
            {
                Console.WriteLine("Invalid side length. Must be a positive number.");
                i--; // retry this input
            }
        }

        double a = sides[0], b = sides[1], c = sides[2];

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }
        else
        {
            Console.WriteLine("The lengths do not form a valid triangle.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}