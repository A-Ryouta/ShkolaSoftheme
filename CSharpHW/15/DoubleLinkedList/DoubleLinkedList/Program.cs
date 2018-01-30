using System;

namespace DoubleLinkedList
{
    internal class Program
    {
        private static void Main()
        {
            var list = new DoubleLinkedList<int>();
            const int testedLength = 4;

            for (var i = 0; i < testedLength; i++)
            {
                list.AddFirst(i);
            }
            list.AddLast(4);

            DoWork(list, 3);
            list.Remove(2);
            DoWork(list, 2);

            Console.ReadLine();
        }

        private static void DoWork<T>(DoubleLinkedList<T> list, T item)
        {
            Console.WriteLine("Double linked list contains {0} : {1}",item, list.Contains(item));
            Console.WriteLine("Double linked list has {0} elements", list.Count);

            var array = list.ToArray();

            foreach (var value in array)
            {
                Console.Write("{0} ", value);
            }

            Console.WriteLine();
        }
    }
}
