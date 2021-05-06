using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class.  
            int int1 = 12;
            int int2 = 3;

            // Call the method in the class, passing in two numbers.
            Operation.Multiply(int1, int2);

            // Call the method in the class, specifying the parameters by name.
            Operation.Multiply(int1: int1, int2: int2);

            Console.ReadLine();
        }
    }
}
