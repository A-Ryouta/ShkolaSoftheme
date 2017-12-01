using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main()
        {
            QueueTask();
            StackTask();
            DictionaryTask();

            Console.ReadLine();
        }

        static void QueueTask()
        {
            Queue<Human> forOrder = new Queue<Human>();
            forOrder.Enqueue(new Human("Pablo"));
            forOrder.Enqueue(new Human("Frodo"));
            forOrder.Enqueue(new Human("Sam"));
            forOrder.Enqueue(new Human("Tony"));
            forOrder.Enqueue(new Human("Bruce"));

            Console.WriteLine("Queue:");
            foreach (var human in forOrder)
            {
                Console.WriteLine(human.Name);
            }

            Console.WriteLine("Queue has {0} members with {1} on the peek.\n", forOrder.Count, forOrder.Peek().Name);
            Console.WriteLine("Deleting one human from queue...\n");
            forOrder.Dequeue();
            foreach (var human in forOrder)
            {
                Console.WriteLine(human.Name);
            }
            Console.WriteLine("Queue has {0} members with {1} on the peek.\n", forOrder.Count, forOrder.Peek().Name);
        }

        static void StackTask()
        {
            Stack<Human> dock = new Stack<Human>();

            dock.Push(new Human("Omar"));
            dock.Push(new Human("Oleg"));
            dock.Push(new Human("Andrew"));
            dock.Push(new Human("Ivan"));
            dock.Push(new Human("Sabrina"));

            Console.WriteLine("Stack:");
            foreach (var human in dock)
            {
                Console.WriteLine(human.Name);
            }

            Console.WriteLine("Stack has {0} members with {1} on the top.\n", dock.Count, dock.Peek().Name);
            Console.WriteLine("Deleting two humans from stack...\n");
            dock.Pop();
            dock.Pop();
            foreach (var human in dock)
            {
                Console.WriteLine(human.Name);
            }
            Console.WriteLine("Stack has {0} members with {1} on the top.\n", dock.Count, dock.Peek().Name);
        }

        static void DictionaryTask()
        {
            Dictionary<int, Human> clientOrders = new Dictionary<int, Human>();
            clientOrders.Add(1,new Human("Rosa"));
            clientOrders.Add(2, new Human("Mark"));
            clientOrders.Add(3, new Human("Tomas"));
            clientOrders.Add(4, new Human("Serge"));
            clientOrders.Add(5, new Human("Corvin"));

            Console.WriteLine("Dictionary:");

            foreach (var clientOrder in clientOrders)
            {
                Console.WriteLine("Order = {0} Client = {1}", clientOrder.Key, clientOrder.Value.Name);
            }

            try
            {
                clientOrders.Add(3, new Human("Nikolas"));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Dictionary already contains this key: 3");
            }

            Console.WriteLine("For key 4 value = {0}", clientOrders[4].Name);
            clientOrders[4] = new Human("Jack");
            Console.WriteLine("For key 4 new value = {0}", clientOrders[4].Name);

            foreach (var clientOrder in clientOrders)
            {
                Console.WriteLine("Order = {0} Client = {1}", clientOrder.Key, clientOrder.Value.Name);
            }
        }
    }
}
