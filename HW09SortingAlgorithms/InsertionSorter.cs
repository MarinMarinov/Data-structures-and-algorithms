namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Very fast for small number of elements in the collection.
    /// Array.Sort() implements InsertionSort algorithm for collections less than 8 elements.
    /// Between 8 and 100 elements it use MergeSort and above 100 elements QuickSort.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InsertionSorter<T>:ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                T value = collection[i];

                int index = i;
                while (index > 0 && collection[index - 1].CompareTo(value) >= 0)
                {
                    collection[index] = collection[index - 1];
                    index--;
                }
                collection[index] = value;
            }
        }
    }
}