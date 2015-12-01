namespace Task02
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var array = new[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            var dictionary = array.GroupBy(s => s).ToDictionary(s => s.Key, s => s.Count());

            var listofEvens = dictionary.Where(s => s.Value%2 == 0).Select(s => s.Key).ToList();
            var listofOdds = dictionary.Where(s => s.Value%2 != 0).Select(s => s.Key).ToList();

            Console.WriteLine(string.Format("Language/s with even number of appearance {0}", string.Join(", ", listofEvens)));
            Console.WriteLine(string.Format("Language/s with odd number of appearance {0}", string.Join(", ", listofOdds)));
        }
    }
}
