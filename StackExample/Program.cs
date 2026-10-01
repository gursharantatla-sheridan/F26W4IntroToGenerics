namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            Console.WriteLine("Total items: " + stack.Count);
            foreach (int i in stack)
                Console.WriteLine(i);

            //int num = stack[2];

            // Pop()
            int num = stack.Pop();  // return 40
            Console.WriteLine("\nAfter pop:");
            Console.WriteLine("num = " + num);

            Console.WriteLine("\nTotal items: " + stack.Count);
            foreach (int i in stack)
                Console.WriteLine(i);


            // Peek()
            num = stack.Peek();
            Console.WriteLine("\nAfter peek:");
            Console.WriteLine("num = " + num);

            Console.WriteLine("\nTotal items: " + stack.Count);
            foreach (int i in stack)
                Console.WriteLine(i);
        }
    }
}
