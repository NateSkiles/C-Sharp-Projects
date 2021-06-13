using System;

namespace ParsingEnums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week.
            Console.Write("Please enter the current day of the week: ");
            try
            {
                // Assign the value to a variable of enum data type.
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());
                Console.WriteLine("Current day: {0}", currentDay);
            }
            catch (Exception)
            {
                // Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

    }
}
