using System;

namespace GenericIterator
{
    class Program
    {
        static void Main()
        {
            ConcreteAggregate<string> a = new ConcreteAggregate<string>
            {
                [0] = "Item A",
                [1] = "Item B",
                [2] = "Item C",
                [3] = "Item D"
            };

            ConcreteIterator<string> i = new ConcreteIterator<string>(a);

            Console.WriteLine("Iterating over collection:");

            var item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
    }
}
