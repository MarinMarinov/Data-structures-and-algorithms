namespace Task01
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var array = new[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            //var dictionary = array.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            // using custom implementation
            var dictionary = Group(array);
            
            foreach(var pair in dictionary)
            {
                Console.WriteLine("Number {0} -> Count {1}", pair.Key, pair.Value);
            }
        }

        public static Dictionary<double, int> Group(double[] array)
        {
            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            for (var i = 0; i < array.Length; i++)
            {
                int count = 1;
                if (dictionary.ContainsKey(array[i]))
                {
                    count = dictionary[array[i]] + 1;
                }

                dictionary[array[i]] = count;
            }

            return dictionary;
        } 
    }
}