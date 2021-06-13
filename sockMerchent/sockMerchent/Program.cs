using System.Collections.Generic;
using System.Linq;
using System;

class Result
{

    /*
     * There is a large pile of socks that must be paired by color. 
     * Given an array of integers representing the color of each sock, 
     * determine how many pairs of socks with matching colors there are.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        List<int> set = new List<int>();
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            int element = ar[i];
            if (set.Contains(element))
            {
                set.Remove(element);
                count++;
            }
            else
            {
                set.Add(element);
            }
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the number of socks in the pile");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Console.WriteLine("Please enter the colors of the socks in the pile");
        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(
            arTemp => Convert.ToInt32(arTemp)).ToList();

        while (ar.Count != n)
        {
            ar.Clear();
            Console.Write("Please make sure you enter the same amount of colors as there are socks in the pile:\n");
            ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(
            arTemp => Convert.ToInt32(arTemp)).ToList();
        }


        int result = Result.sockMerchant(n, ar);

        Console.WriteLine("Number of matching paris of socks: \n{0}", result);

    }
}
