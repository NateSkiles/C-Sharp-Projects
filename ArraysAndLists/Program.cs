using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Nate");
        stringList.Add("How");
        stringList.Add("Are");

        Console.WriteLine(stringList[0]);

        //List<int> intlist = new List<int>();
        //intlist.Add(4);
        //intlist.Add(6);
        //intlist.Add(10);
        //intlist.Remove(10);

        //Console.WriteLine(intlist[0]);

        // These three statements serve the same purpose. The last one is the easiest way to instantiate a num array with it's entries.
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //numArray2[4] = 640;

        //Console.WriteLine(numArray2[4]);


        Console.ReadLine();
    }
}

