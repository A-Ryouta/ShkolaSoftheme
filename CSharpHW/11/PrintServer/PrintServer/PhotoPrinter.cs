using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintServer
{
    public class PhotoPrinter : Printer
    {
        public override void Print(string s)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            base.Print(s);

            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Print(Photo ph)
        {
            Console.WriteLine(ph.Photograph);
        }
    }
}
