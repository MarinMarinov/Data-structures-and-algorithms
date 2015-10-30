//Write a program that reads from the console a sequence of positive integer numbers.
//The sequence ends when empty line is entered. Calculate and print the sum and average of the elements of the sequence. 
//Keep the sequence in List<int>.

namespace Task01
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();
            int n = 0;
            int sum = 0;

            Console.WriteLine("Enter some number or enter empty line to stop");

            while (int.TryParse(Console.ReadLine(), out n))
            {
                if (n >= 0)
                {
                    numbers.Add(n);
                    sum += n;
                }
            }

            Console.WriteLine("The sum of numbers is: " + sum);
            Console.WriteLine("The average number is: " + (double)sum / numbers.Count);
        }
    }
}
