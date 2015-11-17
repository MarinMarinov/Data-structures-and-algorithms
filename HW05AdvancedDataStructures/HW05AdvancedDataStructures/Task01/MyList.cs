namespace Task01
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyList<T> : IComparable<MyList<T>>, IEnumerable<T>
    {
        private IList<T> list;

        public MyList()
        {
            this.list = new List<T>();
        }

        public int Count
        {
            get { return this.list.Count; }
        }

        public MyList(IList<T> collection)
        {
            this.list = collection;
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public void Remove(T element)
        {
            this.list.Remove(element);
        }

        public void RemoveAt(int index)
        {
            this.list.RemoveAt(index);
        }

        public int CompareTo(MyList<T> other)
        {
            return this.list.Count.CompareTo(other.Count) * (-1); // *(-1) to return the longest, not the shortest list!!!
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < this.list.Count; i++)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}