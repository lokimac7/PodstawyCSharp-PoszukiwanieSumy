using System;
using System.Collections.Generic;

namespace PoszukiwanieSumy
{
    class Program
    {
        static void Main(string[] args)
        {
            SumSearching ss = new SumSearching();
            Console.WriteLine(ss.IsSumExist(new int[] { 10, 15, 3, 7 }, 17));
            Console.WriteLine(ss.IsSumExist(new int[] { 10, 15, 3, 9 }, 17));
            Console.WriteLine(ss.IsSumExist(new int[] { 0, 0, 0, 0 }, 17));
            Console.ReadKey();
        }
    }

    public class SumSearching
    {
        bool result = false;
        public bool IsSumExist(int[]numbers, int k)
        {
            foreach (var item in numbers)
            {
                foreach (var item2 in numbers)
                {
                    result = (k - item2 == item) ? true : false;
                    if (result) break;
                }
            }
            return result;
        }
    }
}
