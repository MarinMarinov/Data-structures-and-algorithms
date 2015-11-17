// Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.

using System;

public class Startup
{
    static void Main()
    {
        Console.WriteLine("Enter Vector size(numbers of loops to execute)");
        int vectorSize = int.Parse(Console.ReadLine());
        int[] vector = new int[vectorSize];
        int initialIndex = 0;

        BuildVectors(initialIndex, vector);
    }

    private static void BuildVectors(int currentIndex, int[] currentVector)
    {
        if (currentIndex >= currentVector.Length)
        {
            Console.WriteLine(string.Join(" ", currentVector));
        }
        else
        {
            for (var i = 1; i <= currentVector.Length; i++)
            {
                currentVector[currentIndex] = i;
                BuildVectors(currentIndex + 1, currentVector);
            }
        }
    }
}