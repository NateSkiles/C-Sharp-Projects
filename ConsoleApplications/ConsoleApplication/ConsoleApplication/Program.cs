using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            // Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
            Console.WriteLine("Please enter a whole integer: ");
            int userInt1 = Convert.ToInt32(Console.ReadLine());
            int userProduct = userInt1 * 50;
            Console.WriteLine("Your number (" + userInt1 + ") multiplied by 50 equals: " + userProduct);

            // Takes an input from the user, adds 25 to it, then prints the result to the console.
            Console.WriteLine("\nPlease enter another whole integer: ");
            int userInt2 = Convert.ToInt32(Console.ReadLine());
            int userSum = userInt2 + 25;
            Console.WriteLine("Your number (" + userInt2 + ") plus 25 equals: " + userSum);

            // Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("\nPlease enter another integer (can be a non-whole number): ");
            double userInt3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your number (" + userInt3 + ") divided by 12.5 equals: " + userInt3/12.5);

            // Takes an input from the user, checks if it is greater than 50, then prints the true / false result to the console.
            Console.WriteLine("\nPlease enter a whole integer: ");
            int userInt4 = Convert.ToInt32(Console.ReadLine());
            bool userCompare = userInt4 > 50;
            Console.WriteLine("It is " + userCompare + " that your number (" + userInt4 + ") is greater than 50.");

            // Takes an input from the user, divides it by 7, then prints the remainder to the console(tip: think % operator).
            Console.WriteLine("\nPlease enter one last whole integer: ");
            int userInt5 = Convert.ToInt32(Console.ReadLine());
            int userRemainder = userInt5 % 7;
            if (userRemainder == 0)
            {
                Console.WriteLine("Your number (" + userInt5 + ") is divisible by 7! Which means there is a remainder of: " + userRemainder);
            }
            else
            {
                Console.WriteLine("Your number (" + userInt5 + ") divides into 7 with a remainder of: " + userRemainder);
            }


            Console.ReadLine();
        }
    }
}
