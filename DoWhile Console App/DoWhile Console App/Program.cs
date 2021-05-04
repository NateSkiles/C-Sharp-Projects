using System;

namespace DoWhile_Console_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int isEven = number % 2;
            bool isGuessed = isEven == 0;

            // While isGuessed is false, do:
            do
            {
                switch (isEven)
                {
                    // If isEven equals 0, the number is even.
                    case 0:
                        Console.WriteLine("Correct! You guessed an even number");
                        isGuessed = true;
                        break;
                    // If isEven equals 1, the number is odd.
                    case 1:
                        Console.WriteLine("Incorrect, you guess wrong.");
                        Console.WriteLine("Guess again: ");
                        isEven = Convert.ToInt32(Console.ReadLine()) % 2;
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
