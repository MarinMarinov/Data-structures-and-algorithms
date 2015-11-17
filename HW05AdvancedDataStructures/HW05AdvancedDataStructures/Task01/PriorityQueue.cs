namespace Task01
{
    using System;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public class PriorityQueue<T> where T: IComparable<T>
    {
        private OrderedBag<T> orderedBag;

        public PriorityQueue()
        {
            this.orderedBag = new OrderedBag<T>();
        }

        public int Count
        {
            get { return this.orderedBag.Count; }
        }

        public void Enqueue(T element)
        {
            this.orderedBag.Add(element);
        }

        public void EnqueueMany(IEnumerable<T> collection)
        {
            this.orderedBag.AddMany(collection);
        }

        public T Dequeue()
        {
            T element = this.orderedBag.RemoveFirst();
            return element;
        }
    }
}