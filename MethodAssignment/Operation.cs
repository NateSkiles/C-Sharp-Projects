using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Operation
    {
        // Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result.
        public static int Multiply(int int1, int int2 = 1)
        {
            int calculated = int1 * int2;
            return calculated;
        }
    }
}
