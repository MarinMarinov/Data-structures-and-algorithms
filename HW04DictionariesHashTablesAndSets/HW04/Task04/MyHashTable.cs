namespace Task04
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MyHashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private const int InitialCapacity = 16;
        private const double OverLoadLimit = 0.75;

        private LinkedList<KeyValuePair<K, T>>[] linkedList;
        private int occupiedLinkedListsCounter;
        private int elementsCounter;

        
        public MyHashTable()
            : this(InitialCapacity) { }

        public MyHashTable(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Invalid table size");
            }

            this.linkedList = new LinkedList<KeyValuePair<K, T>>[capacity];
            this.occupiedLinkedListsCounter = 0;
            this.elementsCounter = 0;
        }
     
        public MyHashTable(int capacity, MyHashTable<K, T> hashTable)
            : this(capacity)
        {
            foreach (var pair in hashTable)
            {
                this.Add(pair.Key, pair.Value);
            }
        }

        public void Add(K key, T value)
        {
            this.AutoGrow();

            var elementToAdd = new KeyValuePair<K, T>(key, value);

            int position = this.GetLinkedListPosition(key);

            if (this.linkedList[position] == null)
            {
                this.linkedList[position] = new LinkedList<KeyValuePair<K, T>>();
                this.linkedList[position].AddFirst(elementToAdd);
                this.occupiedLinkedListsCounter++;
            }
            else
            {
                this.Remove(key);

                if (this.linkedList[position].Count == 0)
                {
                    this.occupiedLinkedListsCounter++;
                }

                this.linkedList[position].AddLast(elementToAdd);
            }

            this.elementsCounter++;
        }

        public bool Find(K key, out T value)
        {
            int position = this.GetLinkedListPosition(key);

            if (this.linkedList[position] != null && this.linkedList[position].Count != 0)
            {
                foreach (var pair in this.linkedList[position])
                {
                    if (pair.Key.Equals(key))
                    {
                        value = pair.Value;
                        return true;
                    }
                }
            }

            value = default(T);
            return false;
        }

        public void Remove(K key)
        {
            int position = this.GetLinkedListPosition(key);

            if (this.linkedList[position] != null && this.linkedList[position].Count != 0)
            {
                T valueToRemove;

                if (Find(key, out valueToRemove))
                {
                    var nodeToRemove = this.linkedList[position].First(x => x.Key.Equals(key));

                    this.linkedList[position].Remove(nodeToRemove);

                    this.elementsCounter--;

                    if (this.linkedList[position].Count == 0)
                    {
                        this.occupiedLinkedListsCounter--;
                    }
                }
            }
        }

        public void Clear()
        {
            this.linkedList = new LinkedList<KeyValuePair<K, T>>[this.linkedList.Length];
            this.occupiedLinkedListsCounter = 0;
            this.elementsCounter = 0;
        }

        public T this[K key]
        {
            get
            {
                T returnValue;

                this.Find(key, out returnValue);

                return returnValue;
            }

            set
            {
                this.Add(key, value);
            }
        }

        public int Count
        {
            get
            {
                return this.elementsCounter;
            }
        }

        public K[] Keys
        {
            get
            {
                var listOfKeys = new List<K>(this.elementsCounter);

                foreach (var pair in this)
                {
                    listOfKeys.Add(pair.Key);
                }

                return listOfKeys.ToArray();
            }
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var list in this.linkedList)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                    {
                        yield return pair;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private int GetLinkedListPosition(K key)
        {
            var position = key.GetHashCode() % this.linkedList.Length;

            if (position < 0)
            {
                position = position * (-1);
            }

            return position;
        }

        private void AutoGrow()
        {
            if (this.occupiedLinkedListsCounter >= this.linkedList.Length * OverLoadLimit)
            {
                var newTable = new MyHashTable<K, T>(this.linkedList.Length * 2);

                foreach (var pair in this)
                {
                    newTable.Add(pair.Key, pair.Value);
                }

                this.linkedList = newTable.linkedList;
            }
        }
    }
}