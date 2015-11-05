using System.Collections.Generic;

namespace Task01
{
    public class Node<T>
    {
        private T value;

        private List<Node<T>> children;

        public Node(T value)
        {
            this.value = value;
            this.children = new List<Node<T>>();
        }

        public List<Node<T>> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}