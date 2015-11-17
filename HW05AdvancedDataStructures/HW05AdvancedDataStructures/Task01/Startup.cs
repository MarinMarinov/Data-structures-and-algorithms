namespace Task01
{
    using System;

    public class Startup
    {
        static void Main()
        {
            var stringsQueue = new PriorityQueue<string>();

            stringsQueue.Enqueue("Bacho");
            stringsQueue.Enqueue("Boko");
            stringsQueue.Enqueue("Becko");

            var listOfA = new MyList<string>() { "Acho", "Aaaaa" };
            stringsQueue.EnqueueMany(listOfA);


            var first = stringsQueue.Dequeue();
            Console.WriteLine(first); // Aaaaa

            var listOfB = new MyList<string>() { "Bacho", "Boko", "Becko" };
            var listOfC = new MyList<string>() { "Cacho", "Coko", "Cecko" };

            var listsQueue = new PriorityQueue<MyList<string>>();
            listsQueue.Enqueue(listOfA);
            listsQueue.Enqueue(listOfB);
            listsQueue.Enqueue(listOfC);

            var theLongestList = listsQueue.Dequeue();
            Console.WriteLine(theLongestList.Count); //3 - the listOfB
            foreach (var item in theLongestList)
            {
                Console.WriteLine(item);
            }

            theLongestList = listsQueue.Dequeue();
            Console.WriteLine(theLongestList.Count); //3 - the listOfC
            foreach (var item in theLongestList)
            {
                Console.WriteLine(item);
            }

            theLongestList = listsQueue.Dequeue();
            Console.WriteLine(theLongestList.Count); // 2 - the listOfA
            foreach (var item in theLongestList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(listsQueue.Count); //0
        }
    }
}
