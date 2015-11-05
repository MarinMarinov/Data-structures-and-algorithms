using System;

namespace Task05
{
    public class Startup
    {
        public static void Main()
        {
            var firstSet = new HashedSet<string>();
            var secondSet = new HashedSet<string>();

            firstSet.Add("Pesho");
            firstSet.Add("Gosho");
            firstSet.Add("Tosho");

            secondSet.Add("Ivan");
            secondSet.Add("Petkan");
            secondSet.Add("Dragan");

            Console.WriteLine(firstSet);
            Console.WriteLine(secondSet);

            Console.WriteLine(firstSet.Intersect(secondSet));
            Console.WriteLine(secondSet.Intersect(firstSet));

            Console.WriteLine(firstSet.Union(secondSet));
            Console.WriteLine(secondSet.Union(firstSet));

            firstSet.Remove("Pesho");
            firstSet.Remove("Tosho");
            Console.WriteLine(firstSet);

            Console.WriteLine(firstSet.Find("Tosho"));
            Console.WriteLine(firstSet.Find("Gosho"));

            Console.WriteLine(firstSet.Count);
        }
    }
}