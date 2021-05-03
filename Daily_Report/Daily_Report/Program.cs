using System;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            // Write greeting to console.
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("\nStudent Daily Report:");

            // Get Student's Name.
            Console.WriteLine("What is your name?: ");
            string studentName = Console.ReadLine();

            // Get Student's Course.
            Console.WriteLine("What course are you currently on?: ");
            string studentCourse = Console.ReadLine();

            // Get page number as string, convert to Byte data type for whole numbers up to (+)255.
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            byte studentPage = Convert.ToByte(pageNumber);

            // Get help, cast string as bool.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool studentHelp = Convert.ToBoolean(needHelp);


            Console.WriteLine("Were there any postive experiences you'd like to share? Please give specifics.");
            string studentExperiences = Console.ReadLine();            


            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine();


            Console.WriteLine("How many hours did you study for today?");
            string studyHours = Console.ReadLine();
            byte studentHours = Convert.ToByte(studyHours);

            Console.WriteLine("Thank  you for your answers. An Instructor will respond to this shortly. Have a great day!");

            // Wait for input before shutting window.
            Console.Read();
        }
    }
}
