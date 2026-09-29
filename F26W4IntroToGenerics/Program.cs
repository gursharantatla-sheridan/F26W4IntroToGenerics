namespace F26W4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            object o = i;  // boxing - value type to ref type

            i = (int)o;  // unboxing - ref type to value type

            //o = "hello";
            //i = (int)o;


            //if (AreEqual(5, "hello"))
            if (AreEqual<int>(5, 5))
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");
        }

        // non-generic method
        static bool AreEqual(object value1, object value2)
        {
            return value1.Equals(value2);
        }

        // generic method
        static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
