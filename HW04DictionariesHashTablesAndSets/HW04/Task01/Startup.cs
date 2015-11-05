using System;
using System.Linq;

namespace Task01
{
    public class Startup
    {
        public static void Main()
        {
            var array = new[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            var dictionary = array.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            foreach(var pair in dictionary)
            {
                Console.WriteLine("Number {0} -> Count {1}", pair.Key, pair.Value);
            }
        }
    }
}
