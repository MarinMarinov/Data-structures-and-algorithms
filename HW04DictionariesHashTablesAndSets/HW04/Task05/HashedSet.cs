namespace Task05
{
    using System.Collections.Generic;
    using Task04;

    public class HashedSet<T> : IEnumerable<T>
    {
        private MyHashTable<int, T> elements;

        public HashedSet()
        {
            this.elements = new MyHashTable<int, T>();
        }

        public void Add(T element)
        {
            this.elements.Add(element.GetHashCode(), element);
        }

        public void Remove(T element)
        {
            this.elements.Remove(element.GetHashCode());
        }

        public T Find(T element)
        {
            T returnedElement;
            if (this.elements.Find(element.GetHashCode(), out returnedElement))
            {
                return returnedElement;
            }

            return default(T);
        }

        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }

        public void Clear()
        {
            this.elements.Clear();
        }


        public HashedSet<T> Intersect(HashedSet<T> other)
        {
            HashedSet<T> newSet = new HashedSet<T>();

            foreach (var element in this)
            {
                foreach (var otherElement in other)
                {
                    if (element.Equals(otherElement))
                    {
                        newSet.Add(element);
                    }
                }
            }

            return newSet;
        }

        public HashedSet<T> Union(HashedSet<T> other)
        {
            HashedSet<T> newSet = new HashedSet<T>();

            foreach (var element in this)
            {
                newSet.Add(element);
            }

            foreach (var element in other)
            {
                newSet.Add(element);
            }

            return newSet;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var pair in this.elements)
            {
                yield return pair.Value;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(", ", this);
        }
    }
}