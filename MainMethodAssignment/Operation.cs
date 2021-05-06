using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Operation
    {
        // Create a class. In that class, create a method that will take in an integer, create a math
        // operation for this integer(addition, subtraction, etc.), then return the answer as an integer.
        public static int Addition(int inputInt)
        {
            int outputInt = inputInt + 5;
            return outputInt;
        }
        
        // Add a second method to the class with the same name that will take in a decimal,
        // create a different math operation for it, then return the answer as an integer.
        public static decimal Addition(decimal inputDcml)
        {
            int outputInt = Decimal.ToInt32(inputDcml + 10m);
            return outputInt;
        }

        // Add a third method to the class, with the same name, that will take in a string,
        // convert it to an integer if possible, do a different math operation to it,
        // then return the answer as an integer.
        public static string Addition(string inputStr)
        {
            int inputInt = Convert.ToInt32(inputStr);
            int outputInt = inputInt * 3;

            return outputInt;
        }
    }
}
