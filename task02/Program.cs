using System;

namespace task02
{
    internal static class Program
    {
        private static void Main()
        {
            var myList = new MyList<int>(new int[] {1, 2});
            myList.Add(3);
            Console.WriteLine(myList[2]);
            Console.WriteLine(myList.Length);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}