using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create a list of integers.Ask the user for a number to divide each number in the list by.
        //Write a loop that takes each integer in the list, divides it by the number the user entered,
        //and displays the result to the screen.
        List<int> list = new List<int>() { 8, 10, 15, 12, 27 };
        Console.Write("Please enter a non-zero integer to divide each item in the list by:");
        foreach (int i in list)
        {
            Console.Write(" " + i );
        }
        Console.Write(" / >> ");

        // Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program print a message to the display to let you know the
        // has emerged from the try/catch block and continued on with program executionIn the catch block, display the error message to the screen.
        try
        {
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.Write("The list divided by your divisor \"" + divisor + "\" equals:\n");
            foreach (int i in list)
            {
                // Divide each item in the list by the divisor, round answer to the second decimal place.
                Console.Write(" " + Math.Round((double)(i) / divisor, 2, MidpointRounding.AwayFromZero));
            }
            Console.WriteLine("\nTry");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please do not divide by 0.");
            Console.WriteLine("\nCatch");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("\nCatch");
        }
        finally
        {
            Console.WriteLine("\n\nYou have emerged from the try/catch block!");
            Console.ReadLine();
        }
    }
}

