using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.WriteLine("--- Ticket Price Calculator ---");
        Console.Write("Enter your age: ");

        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative.");
            }
            else
            {
                double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;
                Console.WriteLine($"Ticket Price: GHC{price:0.00}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}