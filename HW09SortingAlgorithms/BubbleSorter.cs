namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class BubbleSorter<T>:ISorter<T> where T: IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                for (var j = 0; j < collection.Count - 1; j++)
                {
                    if (collection[j].CompareTo(collection[j + 1]) >= 0)
                    {
                        T temp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = temp;
                    }
                }
            }
        }
    }
}