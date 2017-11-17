using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer print = new Printer();
            ColourPrinter cPrint = new ColourPrinter();
            PhotoPrinter phPrint = new PhotoPrinter();
            Photo photo = new Photo();

            print.Print("Standart");

            cPrint.Print("Colour");
            cPrint.Print("Colour Extend", ConsoleColor.Red);

            phPrint.Print("Photo");
            phPrint.Print(photo);

            Console.ReadLine();
        }
    }
}
