using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class and call the one method,
            //passing in an integer.Display the result to the screen.
            int input = 14;
            int operated = Operation.Addition(input);
            Console.WriteLine("Our input {0} when operated on with our addition method equals {1}.", input, operated);
            Console.WriteLine("\tAddition method(int) added 5 to our input.");

            // In the Main() method of the console app, instantiate the class and call the second method,
            // passing in a decimal. Display the result to the screen.
            decimal input2 = 16.05m;
            int operated2 = Operation.Addition(input2);
            Console.WriteLine("\nDecimal {0} plus 10 equals {1}", input2, operated2);

            // In the Main() method of the console app, instantiate the class and call the third method,
            // passing in a string that equates to an integer. Display the result to the screen.
            Console.Write("\nPlease enter an integer: ");
            string input3 = Console.ReadLine();
            try
            {
                int operated3 = Operation.Addition(input3);
                Console.WriteLine("\n\nOur input {0} times 3 equals {1}", input3, operated3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Cannot convert string to int");
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
