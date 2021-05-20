using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " +testScores[i]);
        //    }
        //}

        //string[] names = { "Nate", "Jake", "Mike", "George" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    if (names[j] == "Nate")
        //    {
        //        Console.WriteLine(names[j]);
        //    }
        //}

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]);
        //}

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}

        //List<string> names = new List<string>() { "Nate", "Jake", "Mike", "George" };

        //foreach (string name in names)
        //{
        //    if (name == "Nate")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}


        List<int> testScores = new List<int>() { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine(passingScores.Count);

        Console.ReadLine();
    }
}

