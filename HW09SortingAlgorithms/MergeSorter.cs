namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            var sortedList = MergeSort(collection);

            collection.Clear();

            foreach (var item in sortedList)
            {
                collection.Add(item);
            }
        }

        private static List<T> MergeSort(IList<T> collection)
        {
            if (collection.Count < 2)
            {
                return collection.ToList();
            }

            List<T> left = new List<T>();
            List<T> right = new List<T>();

            for (int i = 0; i < collection.Count / 2; i++)
            {
                left.Add(collection[i]);
            }

            for (int i = collection.Count / 2; i < collection.Count; i++)
            {
                right.Add(collection[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return MergeLists(left, right);
        }

        private static List<T> MergeLists(IList<T> leftList, IList<T> rightList)
        {
            List<T> answer = new List<T>(leftList.Count + rightList.Count);

            int leftIndex = 0;
            int rightIndex = 0;

            for (int i = 0; i < answer.Capacity; i++)
            {
                if (leftIndex >= leftList.Count)
                {
                    answer.Add(rightList[rightIndex]);
                    rightIndex++;
                }
                else if (rightIndex >= rightList.Count)
                {
                    answer.Add(leftList[leftIndex]);
                    leftIndex++;
                }
                else if (leftList[leftIndex].CompareTo(rightList[rightIndex]) > 0)
                {
                    answer.Add(rightList[rightIndex]);
                    rightIndex++;
                }
                else
                {
                    answer.Add(leftList[leftIndex]);
                    leftIndex++;
                }
            }

            return answer;
        }
    }
}
