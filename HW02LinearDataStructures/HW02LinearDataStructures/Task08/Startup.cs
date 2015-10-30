// *The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
// Write a program to find the majorant of given array (if exists).
// Example:
// {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3

namespace Task08
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            //  List with majorant number 3 -> 6 times from 11 elementgs
            List<int> numbers = new List<int>() { 2, 3, 3, 3, 5, 6, 1, 3, 3, 3, 9 };

            //  List without majorant number 
            //List<int> numbers = new List<int>() { 2, 3, 3, 3, 5, 6, 1, 3, 3, 9 };

            Dictionary<int, int> dictionaryOfNumbers =
                numbers.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            var majorantElementAppearance = dictionaryOfNumbers.Max(x => x.Value);

            var majorantNumber = numbers.FirstOrDefault(x => dictionaryOfNumbers[x] > numbers.Count / 2);

            if (majorantNumber != 0)
            {
                Console.WriteLine("Majorant number is {0} and appears {1} times from {2} elements", majorantNumber, majorantElementAppearance, numbers.Count);
            }
            else
            {
                Console.WriteLine("There is no majorant number");
            }
        }
    }
}
