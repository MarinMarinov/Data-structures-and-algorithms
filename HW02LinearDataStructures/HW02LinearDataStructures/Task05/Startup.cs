//Write a program that removes from given sequence all negative numbers.

namespace Task05
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int>{ 2, -3, -3, 3, -5, -6, 1, -1, 1, -1, -1, 3, -3, -3, -3, -3, 3, 0, 1 };

            numbers.RemoveAll(n => n < 0);

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
