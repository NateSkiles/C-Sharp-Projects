using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
        string[] stringArray = { "Hello", "Yo", "Sup", "Howdy" };
        Console.Write("Please enter a number for the greetings you would like. \n\t0.) Hello \n\t1.) Yo \n\t2.) Sup \n\t3.) Howdy \nWhich greeting would you like (0-3): ");
        int userIndex1 = Convert.ToInt32(Console.ReadLine());

        // Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
        int[] intArray = { 5, 4, 3, 10, 4, 100 };
        Console.Write("Please enter a number between 0-5: ");
        int userIndex2 = Convert.ToInt32(Console.ReadLine());


        // Add in a message that displays when the user selects an index that doesn’t exist.
        if (userIndex1 > 3 || userIndex2 > 5)
        {
            Console.WriteLine("Sorry, that index doesn't exist.");
            Console.Read();
            Environment.Exit(0);
        }

        Console.WriteLine(stringArray[userIndex1]);
        Console.WriteLine(intArray[userIndex2]);

        // Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
        int i = 0;
        List<string> stringList = new List<string>();
        stringList.Add("Nate");
        stringList.Add("Jake");
        stringList.Add("Mike");
        stringList.Add("George");
        stringList.Add("Alice");

        // Display each name from the list.
        Console.WriteLine("\n\nPlease select your name from the list: ");
        foreach (string name in stringList)
        {
            Console.WriteLine("\t" + i + ".) " + name);
            i++;
        }
        Console.Write("Which number user are you?: ");
        int userIndex3 = Convert.ToInt32(Console.ReadLine());

        // Make sure index is in limit of list.
        if (userIndex3 <= 4)
        {
            Console.WriteLine("You selected: " + stringList[userIndex3]);
        }
        else
        {
            Console.WriteLine("User not found..");
        }

        Console.ReadLine();
    }
}

