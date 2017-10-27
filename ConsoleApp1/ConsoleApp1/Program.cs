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
