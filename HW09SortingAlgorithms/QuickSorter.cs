namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class QuickSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            IList<T> sortedCollection = QuickSort(collection.ToList());

            collection.Clear();

            foreach (var item in sortedCollection)
            {
                collection.Add(item);
            }
        }

        private static List<T> QuickSort(List<T> list)
        {
            if (list.Count < 2)
            {
                return list;
            }

            T pivot = list.First();

            List<T> leftList = new List<T>();
            List<T> pivots = new List<T>();
            List<T> rightList = new List<T>();

            foreach (var item in list)
            {
                if (item.CompareTo(pivot) > 0) 
                {
                    rightList.Add(item);
                }
                else if (item.CompareTo(pivot) < 0)
                {
                    leftList.Add(item);
                }
                else
                {
                    pivots.Add(item);
                }
            }

            leftList = QuickSort(leftList);
            rightList = QuickSort(rightList);

            var concatenatedList = new List<T>();
            concatenatedList.AddRange(leftList);
            concatenatedList.AddRange(pivots);
            concatenatedList.AddRange(rightList);

            return concatenatedList;
        }
    }
}