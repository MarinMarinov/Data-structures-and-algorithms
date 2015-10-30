// Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
//  Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
//  2 → 2 times
//  3 → 4 times
//  4 → 3 times

namespace Task07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 2, 3, 3, 3, 5, 6, 1, 4, 4, 4, 1, 3, 3, 7, 8, 8, 9 };

            var numbersInDictionary = numbers.GroupBy(x => x).ToDictionary(key => key.Key, value => value.Count());

            foreach (var keyValue in numbersInDictionary)
            {
                Console.WriteLine("{0} appears {1} times", keyValue.Key, keyValue.Value);
            }
        }
    }
}
