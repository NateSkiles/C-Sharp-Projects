using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Operation
    {
        // Create a class. In that class, create a void method that outputs an integer. 
        public static void Divide(int dividend)
        {
            // Have the method divide the data passed to it by 2.
            int output = dividend / 2;
            Console.WriteLine("\n{0} / 2 = {1}", dividend, output);

        }

        // Create a method with output parameters.
        public static void Multiply()
        {
            Console.WriteLine("\n\nThis function can multiply a number by 2 when passed an integer.");
        }

        public static void Multiply(int product)
        {
            int output = product * 2;
            Console.WriteLine("\n{0} x 2 = {1}", product, output);
        }

        public void myValue(out string x)
        {
            int myInt = 7;
            x = Convert.ToString(myInt);
        }
    }
}
