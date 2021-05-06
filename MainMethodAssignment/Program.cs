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
            Console.WriteLine("\t.addition(int) added 5 to our input.");

            // In the Main() method of the console app, instantiate the class and call the second method,
            // passing in a decimal. Display the result to the screen.
            decimal input2 = 16.05m;
            int operated2 = (int)Operation.Addition(input2);

            // In the Main() method of the console app, instantiate the class and call the third method,
            // passing in a string that equates to an integer. Display the result to the screen.
            string input3 = "4";
            int operated3 = Convert.ToInt32(Operation.Addition(input3));

            Console.ReadLine();
        }
    }
}
