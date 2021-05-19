using System;

namespace task03
{
    internal static class Program
    {
        private static void Main()
        {
            var myDictionary = new MyDictionary<int, string>(new[] {1, 2}, new[] {"a", "b"});
            myDictionary.Add(3, "c");
            Console.WriteLine(myDictionary[2]);
            Console.WriteLine(myDictionary.Length);
            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}