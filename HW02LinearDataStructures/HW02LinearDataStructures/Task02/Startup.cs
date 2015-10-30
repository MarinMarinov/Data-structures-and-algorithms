//Write a program that reads N integers from the console and reverses them using a stack.
// Use the Stack<int> class.

namespace Task02
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Stack<int> numbers = new Stack<int>();
            int n;

            Console.WriteLine("Enter number or empty line to stop!");

            while (int.TryParse(Console.ReadLine(), out n))
            {
                numbers.Push(n);
            }

            Console.WriteLine("The reversed numbers: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
