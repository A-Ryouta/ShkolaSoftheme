using System;

namespace TypeOperations
{
    internal class Program
    {
        private static void Main()
        {
            var something = 5;
            var copy = something;

            PrintSomething(something, copy);            
            copy += 5;
            PrintSomething(something, copy);

            var jerry = new User("Jerry", "Torvald", 21);
            var tom = jerry;

            jerry.Print();
            tom.Print();
            Console.WriteLine();

            tom.Age = 30;

            jerry.Print();
            tom.Print();
            Console.WriteLine();

            var anna = new User();
            anna.Clone(jerry);

            jerry.Print();
            anna.Print();
            Console.WriteLine();

            anna.FirstName = "Anna";
            anna.Age = 19;

            jerry.Print();
            anna.Print();
            Console.ReadLine();
        }

        private static void PrintSomething(params int[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, args[i]);
            }
            Console.WriteLine();
        }
    }
}
