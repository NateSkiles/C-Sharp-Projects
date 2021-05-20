using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main() method, create an object of data type Number and assign an amount to it.
            Number num = new Number();
            num.Amount = 12.00m;
            decimal x = num.Amount;

            // Print this amount to the console.
            Console.WriteLine(x);

            Console.ReadLine();
        }
        public struct Number
        {
            // Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
            public decimal Amount { get; set; }
        }
    }
}
