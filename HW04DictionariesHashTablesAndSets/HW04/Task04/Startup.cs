using System;

namespace Task04
{
    public class Startup
    {
        public static void Main()
        {
            var table = new MyHashTable<string, string>();
            table.Add("first", "Pesho");
            table.Add("second", "Gosho");
            table.Add("third", "Tosho");
            table.Add("fourth", "Ivan");
            Console.WriteLine(table.Count);

            foreach (var pair in table)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }

            string first;
            table.Find("first", out first);
            Console.WriteLine(first);

            table.Remove("second");
            Console.WriteLine(table.Count);
            foreach (var pair in table)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }

            Console.WriteLine(table["fourth"]);


            string[] keys = table.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);

            }

            table.Clear();
            Console.WriteLine(table.Count);
        }
    }
}
