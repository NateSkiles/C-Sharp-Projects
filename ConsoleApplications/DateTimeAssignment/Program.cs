using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints the current date and time to the console.
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            // Asks the user for a number.
            Console.Write("Please enter a number: ");
            byte userInput = Convert.ToByte(Console.ReadLine());

            // Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            DateTime dateTime2 = dateTime.AddHours(userInput);
            Console.WriteLine("Your number of hours ({0}) past the current time is: {1} ", userInput, dateTime2.ToString("t"));

            Console.ReadLine();
        }
    }
}
