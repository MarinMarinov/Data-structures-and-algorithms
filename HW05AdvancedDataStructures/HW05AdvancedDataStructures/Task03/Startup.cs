using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class Startup
    {
        public static void Main()
        {
            var trie = new Trie();

            var words = new StreamReader("../../Text.txt").ReadToEnd().Split(new char[] { '.', '!', '?', ';', ' ', ':', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                trie.AddWord(word);
            }

            var result = new StringBuilder();

            var searchedWords = new StreamReader("../../Words.txt").ReadToEnd().Split(new char[] { '.', '!', '?', ';', ' ', ':', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in searchedWords)
            {
                int occurrences = 0;
                result.Append(word);
                result.Append(" -> ");
                trie.FindWord(word, out occurrences);
                result.Append(occurrences);
                result.AppendLine(" times");
            }

            Console.Write(result.ToString());
        }
    }
}
