// Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).

namespace Task11
{
    public class ListItem<T>
    {
        private T value;
        private ListItem<T> next;

        public ListItem(T value)
        {
            this.Value = value;
        }
        public T Value
        {
            get { return this.value;  }
            set { this.value = value;  }
        }

        public ListItem<T> Next
        {
            get { return this.next;  }
            set { this.next = value;  }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}