using System;
using task02;

namespace task04
{
    internal static class Program
    {
        private static void Main()
        {
            var myList = new MyList<int>(new[] {1, 2});

            foreach (var item in myList.GetArray())
            {
                Console.WriteLine(item);
            }
        }

        private static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = { };
            foreach (T item in list)
            {
                Array.Resize(ref array, array.Length + 1);
                array[^1] = item;
            }

            return array;
        }
    }
}