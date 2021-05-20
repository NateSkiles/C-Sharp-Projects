using System;
using System.IO;

namespace ioAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for a number.
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            // Logs that number to a text file.
            File.WriteAllText(@"C:\\Users\\nates\\Documents\\Tech Academy Projects\\C-Sharp-Projects\\FileIO\\log.txt", userInput);

            // Prints the text file back to the user.
            string userOutput = File.ReadAllText("C:\\Users\\nates\\Documents\\Tech Academy Projects\\C-Sharp-Projects\\FileIO\\log.txt");
            Console.WriteLine(userOutput);

            Console.ReadLine();
        }
    }
}
