using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // A one-dimensional array of strings.
        string[] myArray = { "Nate", "Jake", "Mike", "George" };

        // Ask the user to input some text.
        Console.Write("Please enter text that will be added to items of the array: ");
        string userString = Console.ReadLine();

        // A loop that iterates through each string in the array and adds the user's text input to the end of each string.
        // This step will not output anything to the console, but will update each array element by appending the user's text.
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] += " " + userString;
        }

        bool myLoop = true;
        while (myLoop)
        {
            // Then create a loop that prints off each string in the array on a separate line.
            for (int j = 0; j < myArray.Length; j++)
            {
                Console.WriteLine(myArray[j]);
                // Before loop ends, set outer loop to false.
                if (j == myArray.Length - 1)
                {
                    myLoop = false;
                }
                if (j <= 2)
                {
                    Console.WriteLine("I'm in a loop");
                }
                else if (j >= 3)
                {
                    Console.WriteLine("Peace out!");
                }
            }
        }



        // A list of strings where each item in the list is unique.
        string phrase1 = "\"the quick brown fox jumps over the lazy dog\"";
        List<string> myWords1 = new List<string>() { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

        // Ask the user to input text to search for in the list.
        Console.WriteLine("\n\nSearch for a word in the phrase: " + phrase1);
        string userSearch1 = Console.ReadLine();

        // A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
        bool found = false;
        do
        {
            foreach (string word in myWords1)
            {
                if (word == userSearch1.ToLower())
                {
                    found = true;
                    // IndexOf() method returns the index of an item in a list.
                    int index = myWords1.IndexOf(word);
                    Console.WriteLine("\nWord, \"" + word + "\", found at the index: " + index);
                }
            }
            // Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
            if (found == false)
            {
                Console.WriteLine("Sorry, your word couldn't be found. Try again.");
                userSearch1 = Console.ReadLine();
            }
        }
        // Add code to the loop that stops it from executing once a match has been found.
        while (!found);



        // A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
        string phrase2 = "\"sphinx of black quartz judge my vow\"";
        bool found2 = false;


        List<string> myWords2 = new List<string>() { "sphinx", "vow", "black", "quartz", "my", "vow", "sphinx", "of", "black", "quartz", "quartz", "my", "quartz" };

        Console.WriteLine("\n\nPlease select a word from the phrase to search for: " + phrase2);
        string userSearch2 = Console.ReadLine();

        // Create a loop that iterates through the list and then displays the indices of the items matching the user - selected text.
        do
        {
            // Counter to track index
            int counter = 0;
            foreach (string word in myWords2)
            {
                if (word == userSearch2)
                {
                    Console.WriteLine("\"" + userSearch2 + "\" found at index: " + counter);
                    found2 = true;
                }
                counter++;
            }

            if (found2 == false)
            {
                Console.WriteLine("Sorry, your word couldn't be found. Try again.");
                userSearch2 = Console.ReadLine();
            }
        }
        //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
        while (!found2);



        // Create a list of strings that has at least two identical strings in the list.
        List<string> wordList = new List<string>() { "the", "an", "an", "cat", "dog", "a", "and", "an", "the" };
        List<string> searched = new List<string>();

        // Create a foreach loop that evaluates each item in the list, and displays a message..
        // ..showing the string and whether or not it has already appeared in the list.
        Console.WriteLine("\n\n");

        foreach (string word in wordList) 
        {
            if (searched.Contains(word)) 
            {
                 Console.WriteLine("The string: \"" + word + "\" -- HAS already been displayed.");
            }
            else
            {
                Console.WriteLine("The string: \"" + word + "\" -- has NOT been displayed yet.");
                searched.Add(word);
            }
        }


        Console.ReadLine();
    }
}



