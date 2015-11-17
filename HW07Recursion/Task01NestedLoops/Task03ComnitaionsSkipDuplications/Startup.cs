// Write a recursive program for generating and printing all the combinations without the duplicates of k elements from n-element set.
// Just modify the previous program to skip duplicates:
// Example: n=4, k=2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)

using System;

public class Startup
{
    private static int endNumber;

    public static void Main()
    {
        Console.WriteLine("Enter n - max number");
        int.TryParse(Console.ReadLine(), out endNumber);
        Console.WriteLine("Enter k - number of elements in the set combination(or vector size)");
        int k = int.Parse(Console.ReadLine());

        int[] vector = new int[k];
        int initialIndex = 0;
        int startNumber = 1;

        Combine(initialIndex, vector, startNumber);
    }

    private static void Combine(int currentIndex, int[] currentVector, int startNumber)
    {
        if (currentIndex >= currentVector.Length)
        {
            Console.WriteLine(string.Join(" ", currentVector));
        }
        else
        {
            for (var i = startNumber; i <= endNumber; i++)
            {
                currentVector[currentIndex] = i;
                Combine(currentIndex + 1, currentVector, i + 1);
            }
        }
    }
}