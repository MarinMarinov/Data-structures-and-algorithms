// Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.

namespace Task03
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();
            int n = 0;

            Console.WriteLine("Enter some number or enter empty line to stop");

            while (int.TryParse(Console.ReadLine(), out n))
            {
                if (n >= 0)
                {
                    numbers.Add(n);
                }
            }

            numbers.Sort();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
