// Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
// Write a program to test whether the method works correctly

namespace Task04
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 2, 3, 3, 3, 5, 6, 1, 1, 1, 1, 1, 3, 3, 3, 3, 3, 3 };

            List<int> bestSequence = new List<int>();
            int currentSequenceCount = 1;
            int bestSequenceCount = 0;
            int bestNumber = 0;

            for (var i = 1; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int lastNumber = numbers[i - 1];

                if (currentNumber == lastNumber)
                {
                    currentSequenceCount++;
                }
                else
                {
                    currentSequenceCount = 1;
                }
                if (currentSequenceCount > bestSequenceCount)
                {
                    bestSequenceCount = currentSequenceCount;
                    bestNumber = numbers[i];
                }
            }

            for (var i = 0; i < bestSequenceCount; i++)
            {
                bestSequence.Add(bestNumber);
            }

            Console.WriteLine(string.Join(", ", bestSequence));
        }
    }
}
