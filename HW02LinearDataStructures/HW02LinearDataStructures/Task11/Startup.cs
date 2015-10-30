// Implement the data structure linked list.
// Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
// Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).

namespace Task11
{
    using System;

    public class Startup
    {
        static void Main()
        {
            ListItem<string> first = new ListItem<string>("First");
            ListItem<string> second = new ListItem<string>("Second");
            ListItem<string> third = new ListItem<string>("Third");

            var myLinkedList = new MyLinkedList<string>();
            myLinkedList.FirstElement = first;
            first.Next = second;
            second.Next = third;

            foreach (var item in myLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
