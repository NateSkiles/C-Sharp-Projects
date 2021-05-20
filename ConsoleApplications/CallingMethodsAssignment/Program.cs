using System;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user number to operate on
            Console.WriteLine("What number would you like to do math operations on: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            // Call each method
            Console.Write("Your number doubled is: " + Operation.DoubleNum(userNum));
            Console.Write("\nYour number tripled is: " + Operation.TripleNum(userNum));
            Console.Write("\n" + Operation.OddEven(userNum));

            Console.ReadLine();
        }
    }
}
