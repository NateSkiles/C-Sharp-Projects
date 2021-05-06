using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Operation
    {
        // Create methods of Operation
        // Double and return value passed to it
        public static int DoubleNum(int num)
        {
            return num * num;
        }
        
        // Triple number passed
        public static int TripleNum(int num)
        {
            return num * num * num;
        }

        // Check if number is odd or even
        public static string OddEven(int num)
        {
            string even = num + " is even.";
            string odd = num + " is odd.";

            bool isEven = num % 2 == 0;
            if (isEven)
            {
                return even;
            }
            else
            {
                return odd;
            }
        }
    }
}
