using System;
using System.Text;

namespace StringFunctionsAssignment
{
    class Program
    {
        static void Main()
        {
            //Concatenates three strings.
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            string greeting = "Hello";
            string message = "Welcome to my program";

            string introduction = greeting + ", " + name + ". " + message + "!";
            Console.WriteLine(introduction);

            //Converts a string to uppercase.
            Console.WriteLine("\n" + introduction.ToUpper());

            //Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.
            string myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum ut lacus quis nisl fermentum luctus non ac enim. Vivamus tincidunt vitae velit non molestie.";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(myString);
            stringBuilder.Append(introduction);
            stringBuilder.Append(myString);
            stringBuilder.Append(introduction);
            stringBuilder.Append(myString);

            Console.WriteLine(stringBuilder);

            Console.ReadLine();
        }
    }
}
