namespace Task13
{
    using System;
    using System.Collections.Generic;

    public class MyQueue<T>
    {
        private readonly LinkedList<T> list;

        public MyQueue()
        {
            this.list = new LinkedList<T>();
        }

        public int Count
        {
            get { return this.list.Count; }
        }

        public T Peek
        {
            get
            {
                if (this.list.Count == 0)
                {
                    throw new IndexOutOfRangeException("The Queue is empty!");
                } 
                
                return this.list.First.Value;
            }
        }

        public void Enqueue(T element)
        {
            this.list.AddLast(element);
        }

        public T Dequeue()
        {
            if (this.list.First == null)
            {
                throw new IndexOutOfRangeException("The Queue is empty");
            }

            var elementToRemove = this.list.First.Value;
            this.list.RemoveFirst();

            return elementToRemove;
        }
    }
}