using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main() method of the console app, instantiate the class. Ask the user to input two numbers, one at a time.
            // Let them know they need not enter anything for the second number.
            Console.WriteLine("Please enter up to two integers. (Note: If left blank, number two will default to (1).");

            try 
            {
                Console.Write("Number One: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number Two (optional): ");
                string num2 = Console.ReadLine();

                // If num2 was left blank, only num1 to method. This uses the optional parameter already set to 1
                if (num2 == "")
                {
                    int multiplied = Operation.Multiply(num1);
                    Console.WriteLine(multiplied);
                }
                // If num2 wasn't left blank, num2 with method.
                else
                {
                    int multiplied = Operation.Multiply(num1, Convert.ToInt32(num2));
                    Console.WriteLine(multiplied);
                }
            }
            // Catch any exception errors
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            

            Console.ReadLine();
        }
    }
}
