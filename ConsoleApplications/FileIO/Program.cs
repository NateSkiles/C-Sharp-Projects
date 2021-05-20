using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Here is some text";
            // Write text
            File.WriteAllText(@"C:\\Users\\nates\\Documents\\Tech Academy Projects\\C-Sharp-Projects\\FileIO\\IO\\log.txt", text);
            // Read text
            string text2 = File.ReadAllText("C:\\Users\\nates\\Documents\\Tech Academy Projects\\C-Sharp-Projects\\FileIO\\IO\\log.txt");
            Console.WriteLine(text2);
            Console.ReadLine();
        }
    }
}
