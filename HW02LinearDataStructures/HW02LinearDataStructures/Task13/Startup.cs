// Implement the ADT queue as dynamic linked list. Use generics (LinkedQueue<T>) to allow storing different data types in the queue.

namespace Task13
{
    using System;

    public class Startup
    {
        static void Main()
        {
            var queue = new MyQueue<string>();

            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            Console.WriteLine(queue.Peek); // First

            Console.WriteLine(queue.Dequeue()); // First
            Console.WriteLine(queue.Dequeue()); // Second
            Console.WriteLine(queue.Peek); // Third

            Console.WriteLine(queue.Dequeue()); // Third
            Console.WriteLine(queue.Dequeue()); // Fourth

            Console.WriteLine(queue.Dequeue()); // IndexOutOfRangeException: The Queue is empty
        }
    }
}
