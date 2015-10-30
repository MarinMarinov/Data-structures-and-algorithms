// Implement the ADT stack as auto-resizable array. 
// Resize the capacity on demand (when no space is available to add / insert a new element).

namespace Task12
{
    using System;

    public class Startup
    {
        static void Main()
        {
            var myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(5);

            foreach (var n in myStack)
            {
                Console.WriteLine(n); // 5 3 2 1
            }
            Console.WriteLine("Stack size: " + myStack.Count); // 4
            Console.WriteLine();

            Console.WriteLine("Peek number: " + myStack.Peek); // 5
            Console.WriteLine();

            Console.WriteLine("Pop the upper number");
            Console.WriteLine(myStack.Pop());
            Console.WriteLine();

            Console.WriteLine("New upper number");
            Console.WriteLine(myStack.Peek); //1
            Console.WriteLine();

            Console.WriteLine("Stack size: " + myStack.Count);
        }
    }
}
