namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (var i = 0; i < collection.Count - 1; i++)
            {
                int indexOfCurrentMinElement = i;

                for (var j = i + 1; j < collection.Count; j++)
                {
                    if (collection[indexOfCurrentMinElement].CompareTo(collection[j]) >= 0) // that means collection[indexOfCurrentMinElement] > collection[j]
                    {
                        indexOfCurrentMinElement = j;
                    }
                }

                T tempElement = collection[i];
                collection[i] = collection[indexOfCurrentMinElement];
                collection[indexOfCurrentMinElement] = tempElement;
            }
        }
    }
}
