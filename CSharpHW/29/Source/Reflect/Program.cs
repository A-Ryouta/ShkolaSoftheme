using System;
using Source;

namespace Reflect
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(5);

            Reflector.MethodInfo(acc);

            Console.ReadLine();
        }
    }
}
