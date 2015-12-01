namespace Task03
{
    using System;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var text = new StreamReader("../../text.txt").ReadToEnd().ToLower();

            var splitedWords = text.Split(new char[] { '.', '!', '?', ';', ' ', ':', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

            var dictionary = splitedWords.GroupBy(w => w).ToDictionary(w => w.Key, w => w.Count()).OrderBy(w => w.Value);

            foreach (var pair in dictionary)
            {
                Console.WriteLine("Word: {0} -> appearance {1}", pair.Key, pair.Value);
            }
        }
    }
}
