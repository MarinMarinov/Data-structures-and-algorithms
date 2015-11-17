using System;
using System.Collections.Generic;

namespace Task03BiDictionary
{
    using Wintellect.PowerCollections;

    public class BiDictionary<K1, K2, V>
    {
        private MultiDictionary<K1, V> dictionaryFirst;
        private MultiDictionary<K2, V> dictionarySecond;
        private MultiDictionary<Tuple<K1, K2>, V> dictionaryThird;

        public BiDictionary()
        {
            this.dictionaryFirst = new MultiDictionary<K1, V>(true);
            this.dictionarySecond = new MultiDictionary<K2, V>(true);
            this.dictionaryThird = new MultiDictionary<Tuple<K1, K2>, V>(true);
        }

        public void Add(K1 key1, K2 key2, V value)
        {
            this.dictionaryFirst.Add(key1, value);
            this.dictionarySecond.Add(key2, value);
            this.dictionaryThird.Add(new Tuple<K1, K2>(key1, key2), value);
        }

        public ICollection<V> FindByFirstKey(K1 key)
        {
            return this.dictionaryFirst[key];
        }

        public ICollection<V> FindBySecondKey(K2 key)
        {
            return this.dictionarySecond[key];
        }

        public ICollection<V> FindByBothKeys(K1 key1, K2 key2)
        {
            return this.dictionaryThird[new Tuple<K1, K2>(key1, key2)];
        }
    }
}