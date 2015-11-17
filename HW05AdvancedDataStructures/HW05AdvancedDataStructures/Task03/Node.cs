using System.Collections.Generic;

namespace Task03
{
    internal class Node
    {
        public Node(string value, int occurrences = 0)
        {
            this.Children = new Dictionary<string, Node>();
            this.Value = value;
            this.Occurrences = occurrences;
        }

        public Node(char value, int occurrences = 0)
            : this(value.ToString(), occurrences)
        {
        }

        public string Value { get; set; }

        public int Occurrences { get; set; }

        public Dictionary<string, Node> Children { get; set; }

        public Node Parent { get; set; }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var objAsNode = obj as Node;
            if (objAsNode == null)
            {
                return false;
            }

            return this.Value.Equals(objAsNode.Value);
        }
    }
}