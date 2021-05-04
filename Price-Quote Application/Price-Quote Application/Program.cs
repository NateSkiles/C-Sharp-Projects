using System;

namespace Price_Quote_Application
{
    class Program
    {
        static void Main()
        {
            //The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //The user must then be prompted for the package weight.
            Console.WriteLine("Please enter your package's weight (in lbs.):");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.
            if (packageWeight > 50)
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day!");
                Console.WriteLine("\n\nPress enter to close application...");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //The user must then be prompted for the package width.
            Console.Write("Pleas enter the package's width (in inches): ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            //Then the package height.
            Console.Write("Pleas enter the package's height (in inches): ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            //Then the package length.
            Console.Write("Pleas enter the package's length (in inches): ");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            //If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
            int totalDimensions = packageHeight + packageWidth + packageLength;
            if (totalDimensions > 50)
            {
                Console.WriteLine("\nSorry, package too big to be shipped via Package Express.");
                Console.WriteLine("\n\nPress enter to close application...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            //Next, multiply the three dimensions(height, width, &length) together, and multiply the product by the weight.Finally, divide the outcome by 100.
            //The result of that calculation is the quote.
            double quote = Convert.ToDouble((packageWidth * packageHeight * packageLength) * packageWeight) / 100.00;
            
            //Display the quote to the user as a dollar amount.
            Console.WriteLine("It will cost about $" + quote + " to ship your package.");

            Console.ReadLine();
        }
    }
}
