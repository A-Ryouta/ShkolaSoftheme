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
<<<<<<< HEAD
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
=======
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            
            string singleStr = "*";
            string str = "*****";
            StringBuilder strBuild = new StringBuilder("*****");
                        
            pyramidByTwoLoops(singleStr);            
            pyramidByOneLoop(singleStr);
            pyramidByString(str);
            pyramidByStringBuilder(strBuild);           

            //Console.WriteLine("Hi!");
>>>>>>> 223bccabee16e80192bbc7c0ed8b97db2b53b85c
            Console.ReadLine();
        }

        static void pyramidByTwoLoops(string s)
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
        }
        static void pyramidByOneLoop(string s)
        {
            int i = 5, n = 0;
            do
            {
                Console.Write(s);
                i--;
                if (i == n)
                {
                    Console.WriteLine();
                    i = 5;
                    n++;
                }
            } while (n != 5);
        }
        static void pyramidByString(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(s.Remove(0, i));
            }
        }
        static void pyramidByStringBuilder(StringBuilder s)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(s);
                s.Remove(0, 1);
            }
        }        
    }    
}
