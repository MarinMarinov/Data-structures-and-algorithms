// Write a program for generating and printing all subsets of k strings from given set of strings.
//	Example: s = {test, rock, fun}, k=2
//	(test rock),  (test fun),  (rock fun)

using System;

public class Startup
{
    public static void Main()
    {
        int n = 3;
        int k = 2;

        var set = new string[] { "proba", "test", "alabala" };

        string[] stringToPrint = new string[k];

        Combos(0, n, 0, set, stringToPrint);
    }

    private static void Combos(int index, int n, int start, string[] set, string[] stringToPrint)
    {
        if (index >= stringToPrint.Length)
        {
            Console.WriteLine("( " + string.Join(",", stringToPrint) + " )");
        }
        else
        {
            for (int i = start; i < n; i++)
            {
                stringToPrint[index] = set[i];
                Combos(index + 1, n, i + 1, set, stringToPrint);
            }
        }
    }
}
