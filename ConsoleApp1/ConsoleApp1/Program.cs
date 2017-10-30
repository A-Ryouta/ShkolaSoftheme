using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, i = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            /*
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                n++;
            }
            */
            
            do
            {
                Console.Write("*");
                i++;
                if (i == n)
                {
                    n++;
                    i = 0;
                    Console.Write("\n");
                }
            }
            while (n <= 5);

            Console.BackgroundColor = ConsoleColor.Green;            
            Console.WriteLine("Hi!");
            Console.ReadLine();
        }
    }
}
