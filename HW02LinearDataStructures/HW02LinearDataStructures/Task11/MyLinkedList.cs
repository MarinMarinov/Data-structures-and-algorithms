// Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).

namespace Task11
{
    using System.Collections;
    using System.Collections.Generic;

    public class MyLinkedList<T> : IEnumerable<T>
    {
        private ListItem<T> firstElement;

        public MyLinkedList()
        {
            this.FirstElement = null;
        }

        public MyLinkedList(ListItem<T> firstElement)
        {
            this.FirstElement = firstElement;
        }

        public ListItem<T> FirstElement
        {
            get { return this.firstElement; }
            set { this.firstElement = value;  }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentElement = this.FirstElement;

            while (currentElement != null)
            {
                yield return currentElement.Value;

                currentElement = currentElement.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}