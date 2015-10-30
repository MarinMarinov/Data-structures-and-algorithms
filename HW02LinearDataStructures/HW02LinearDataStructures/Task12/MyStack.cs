namespace Task12
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyStack<T> : IEnumerable<T>
    {
        private const int InitialSize = 2;
        private T[] array;
        private int index;

        public MyStack()
        {
            this.array = new T[InitialSize];
            this.index = 0;
        }

        public void Push(T element)
        {
            if (this.array.Length == this.index)
            {
                this.Resize();
            }

            this.array[this.index] = element;
            this.index++;
        }

        public T Pop()
        {
            if (this.array.Length == 0)
            {
                throw new IndexOutOfRangeException("The stack is empty");
            }

            var indexOfElementToReturn = this.index - 1;
            var elementToReturn = this.array[indexOfElementToReturn];
            Array.Resize(ref this.array, this.array.Length - 1);
            this.index--;
            return elementToReturn;
        }

        public T Peek
        {

            get
            {
                if (this.array.Length == 0)
                {
                    throw new IndexOutOfRangeException("The stack is empty");
                }

                return this.array[this.index - 1];
            }
        }

        public int Count
        {
            get { return this.array.Length; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentIndex = this.index;

            while (currentIndex > 0)
            {
                var currentElement = this.array[--currentIndex];

                yield return currentElement;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void Resize()
        {
            T[] newArray = new T[this.array.Length * 2];
            Array.Copy(this.array, newArray, this.array.Length);
            this.array = newArray;
        }
    }
}