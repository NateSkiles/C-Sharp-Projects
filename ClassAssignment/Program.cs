using System;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main() method, instantiate that class. Have the user enter a number. Call the method on that number.
            Console.WriteLine("Please enter an integer: ");
            try
            {
                int dividend = Convert.ToInt32(Console.ReadLine());
                // Display the output to the screen. It should be the entered number, divided by two.
                Operation.Divide(dividend);
                Operation.Multiply();
                Operation.Multiply(product: dividend);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
