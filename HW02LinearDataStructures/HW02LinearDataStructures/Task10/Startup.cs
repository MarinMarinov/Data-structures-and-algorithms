// We are given numbers N and M and the following operations: a) N = N+1 b) N = N+2 c) N = N*2
// Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
// Hint: use a queue.
// Example: N = 5, M = 16
// Sequence: 5 → 7 → 8 → 16

namespace Task10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            int n = 5;
            int m = 16;
            Queue<int> queue = new Queue<int>();

            while (n <= m)
            {
                queue.Enqueue(m);

                if (m / 2 >= n)
                {
                    if (m % 2 == 0)
                    {
                        m /= 2;
                    }
                    else
                    {
                        m--;
                    }
                }
                else
                {
                    if (m - 2 >= n)
                    {
                        m -= 2;
                    }
                    else
                    {
                        m--;
                    }
                }
            }

            Console.WriteLine(string.Join(" -> ", queue.Reverse()));
        }
    }
}