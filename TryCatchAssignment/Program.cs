using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            bool validAnswer = false;  
            while (!validAnswer)
            {
                try
                {
                    // Ask the user for their age.
                    Console.Write("Please enter your age: ");
                    // TryParse returns false if user input cannot be converted to int. Output to age
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (age < 0)
                    {
                        throw new ArgumentException();
                    }
                    if (!validAnswer) Console.WriteLine("Please enter a valid integer.\n");
                }
                // Display appropriate error messages if the user enters zero or negative numbers.
                catch (ArgumentException)
                {
                    validAnswer = false;
                    Console.WriteLine("Please enter a number greater than 0\n");
                }
                // Display a general message if an exception was caused by anything else.
                catch (Exception)
                {
                    validAnswer = false;
                    Console.WriteLine("Error. Please contact system administrator.");
                }
            }

            // Display the year the user was born.
            DateTime today = DateTime.Now;
            int birthYear = today.Year - age;
            Console.WriteLine(birthYear);

            Console.ReadLine();
        }
    }
}
