using System;

namespace exampleQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue <string> newQueue = new Queue<string>();
            // Add items
            newQueue.Enqueue("A");
            newQueue.Enqueue("B");
            newQueue.Enqueue("C");
            newQueue.Enqueue("D");
            newQueue.Enqueue("E");
            // Checking for a specific element
            Console.WriteLine(newQueue.Contains("C"));
            // Removing an object
            newQueue.Dequeue();
            // Counting total
            Console.WriteLine(newQueue.Count());
            // print all that LOOT!
            foreach (string s in newQueue)
            {
                Console.WriteLine(s);
            }
        }
    }
}
