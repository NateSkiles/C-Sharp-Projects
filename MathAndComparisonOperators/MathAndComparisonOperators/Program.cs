using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine("Five plus ten = " + total);
            //Console.WriteLine(combined);



            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference);

            //int product = 10 * 5;
            //Console.WriteLine(product);

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);



            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse.ToString());

            int roomTemperature = 70;
            int currentTemperature = 72;

            bool isWarm = currentTemperature >= roomTemperature;
            Console.WriteLine(isWarm);

            Console.Read();

        }
    }
}
