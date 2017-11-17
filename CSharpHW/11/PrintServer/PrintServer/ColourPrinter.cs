using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintServer
{
    public class ColourPrinter : Printer
    {
        public override void Print(string s)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            base.Print(s);

            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Print(string s, ConsoleColor cc)
        {
            Console.ForegroundColor = cc;
            Console.WriteLine(s);

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
