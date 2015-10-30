// Write a program that removes from given sequence all numbers that occur odd number of times.

namespace Task06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 2, 3, 3, 4, 4, 6, 1, 1, 7, 9, 9, 10 };

            List<int> numbersPresentedOddTimes = new List<int>();

            for (var i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                // If number appears for first time will be added, if for second - will be deleted
                if (numbersPresentedOddTimes.Contains(currentNumber))
                {
                    numbersPresentedOddTimes.Remove(currentNumber);
                }
                else
                {
                    numbersPresentedOddTimes.Add(currentNumber);
                }
            }

            HashSet<int> numbersPresentedEvenTimes = new HashSet<int>(numbers.Where(n => !numbersPresentedOddTimes.Contains(n)).ToList());
            Console.WriteLine(string.Join(", ", numbersPresentedEvenTimes));
        }
    }
}
