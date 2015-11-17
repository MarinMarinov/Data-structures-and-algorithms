// Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n.
// Example: n=3 → {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}

using System;

public class Startup
{
    private static int n;

    public static void Main()
    {
        Console.WriteLine("Enter n - max number");
        int.TryParse(Console.ReadLine(), out n);

        int[] answer = new int[n];
        bool[] used = new bool[n];

        Permute(0, answer, used);
    }

    private static void Permute(int currentIndex, int[] currentAnswer, bool[] used)
    {
        if (currentIndex >= currentAnswer.Length)
        {
            Console.WriteLine(string.Join(" ", currentAnswer));
        }
        else
        {
            for (int i = 1; i <= currentAnswer.Length; i++)
            {
                if (!used[i - 1])
                {
                    currentAnswer[currentIndex] = i;
                    used[i - 1] = true;
                    Permute(currentIndex + 1, currentAnswer, used);
                    used[i - 1] = false;
                }
            }
        }
    }
}