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


        try
        {
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.Write("The list divided by your divisor \"" + divisor + "\" equals:\n");
            foreach (int i in list)
            {
                Console.Write(" " + Math.Round((double)(i) / divisor, 2, MidpointRounding.AwayFromZero));
            }
            Console.WriteLine("\nTry");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
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




        //Run the code, entering in non - zero numbers as the user. Look at the displayed results.


        //Run the code again, entering in zero as the number to divide by.Note any error messages you get.


        //Run the code once again, entering in a string as the number to divide by.Note any error messages you get.


        //Now put the loop in a try/catch block.Below and outside of the try/catch block,
        //make the program print a message to the display to let you know the program has emerged from the try/catch block
        //and continued on with program execution.In the catch block, display the error message to the screen.
        //Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error messages display
        //on the screen, and that the code after the try/catch block gets executed.

    }
}

