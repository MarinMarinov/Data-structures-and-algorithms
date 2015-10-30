// We are given the following sequence:
// S1 = N;
// S2 = S1 + 1;
// S3 = 2*S1 + 1;
// S4 = S1 + 2;
// S5 = S2 + 1;
// S6 = 2*S2 + 1;
// S7 = S2 + 2;
// ...
// Using the Queue<T> class write a program to print its first 50 members for given N.
// Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

namespace Task09
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            int n = 2;
            int membersCount = 50;
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(n);

            for (var i = 0; i < membersCount - 1; i++)
            {
                int currentNumber = queue.Dequeue();
                Console.Write("{0}, ", currentNumber);

                if (i < membersCount / 3)
                {
                    queue.Enqueue(currentNumber + 1);
                    queue.Enqueue(2 * currentNumber + 1);
                    queue.Enqueue((currentNumber + 1) + 1);
                }
            }

            Console.WriteLine("Queue left members count: {0}", queue.Count);
        }
    }
}
