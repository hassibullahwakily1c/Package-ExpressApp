using System;

class Program
{
    static void Main()
    {
        // Display the welcome message required by the assignment
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask the user for the package weight
        Console.WriteLine("Please enter the package weight:");
        
        // Convert user input from string to decimal
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Check if the package is too heavy
        if (weight > 50)
        {
            // Display error message and end program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Stops the program immediately
        }

        // Ask the user for the package width
        Console.WriteLine("Please enter the package width:");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Ask the user for the package height
        Console.WriteLine("Please enter the package height:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Ask the user for the package length
        Console.WriteLine("Please enter the package length:");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Calculate the total of the dimensions
        decimal dimensionTotal = width + height + length;

        // Check if the package is too large
        if (dimensionTotal > 50)
        {
            // Display error message and end program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Stops the program immediately
        }

        // Calculate the shipping quote:
        // Multiply dimensions together, then multiply by weight, then divide by 100
        decimal quote = (width * height * length * weight) / 100;

        // Display the result formatted as currency (2 decimal places)
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

        // Thank the user
        Console.WriteLine("Thank you!");
    }
}