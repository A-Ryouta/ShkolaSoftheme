using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var something = 5;
            var copy = something;

            PrintSomething(something, copy);            
            copy += 5;
            PrintSomething(something, copy);

            var jerry = new User
            {
                FirstName = "Jerry",
                LastName = "Torvald",
                Age = 21
            };
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

        static void PrintSomething(params int[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, args[i]);
            }
            Console.WriteLine();
        }
    }
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public void Clone(User value)
        {
            this.FirstName = value.FirstName;
            this.LastName = value.LastName;
            this.Age = value.Age;
        }
        public void Print()
        {
            Console.WriteLine("{0} {1} is {2} years old", FirstName, LastName, Age);
        }              
    }
}
