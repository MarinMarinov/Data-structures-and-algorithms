namespace Task03
{
    public class Trie
    {
        private Node root;

        public Trie()
        {
            this.root = new Node("");
        }

        public void AddWord(string word)
        {
            this.InnerAddWord(word, this.root);
        }

        private void InnerAddWord(string wordSubString, Node element)
        {
            if (string.IsNullOrEmpty(wordSubString) || string.IsNullOrWhiteSpace(wordSubString))
            {
                element.Occurrences++;
                return;
            }

            var currentChar = wordSubString[0].ToString();

            if (!element.Children.ContainsKey(currentChar))
            {
                element.Children.Add(currentChar, new Node(currentChar) { Parent = element });
            }

            this.InnerAddWord(wordSubString.Substring(1), element.Children[currentChar]);
        }

        public bool FindWord(string word, out int occurrences)
        {
            return this.InnerTryFindWord(word, out occurrences, root);
        }

        private bool InnerTryFindWord(string wordSubString, out int occurrences, Node element)
        {
            if (string.IsNullOrEmpty(wordSubString) || string.IsNullOrWhiteSpace(wordSubString))
            {
                occurrences = element.Occurrences;
                return true;
            }

            var currentChar = wordSubString[0].ToString();

            if (!element.Children.ContainsKey(currentChar))
            {
                occurrences = 0;
                return false;
            }

            return this.InnerTryFindWord(wordSubString.Substring(1), out occurrences, element.Children[currentChar]);
        }
    }
}