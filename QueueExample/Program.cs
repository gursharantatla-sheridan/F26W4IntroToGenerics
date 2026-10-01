using System.Collections;

namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            Console.WriteLine("Total items: " + queue.Count);
            foreach (int i in queue)
                Console.WriteLine(i);

            //int num = queue[2];

            // Dequeue()
            int num = queue.Dequeue();
            Console.WriteLine("\nAfter dequeue:");
            Console.WriteLine("num = " + num);

            Console.WriteLine("\nTotal items: " + queue.Count);
            foreach (int i in queue)
                Console.WriteLine(i);

            // Peek()
            num = queue.Peek();
            Console.WriteLine("\nAfter peek:");
            Console.WriteLine("num = " + num);

            Console.WriteLine("\nTotal items: " + queue.Count);
            foreach (int i in queue)
                Console.WriteLine(i);
        }
    }
}
