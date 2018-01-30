using System;

namespace PrintServer
{
    internal class Program
    {
        internal static void Main()
        {
            var print = new Printer();
            var cPrint = new ColourPrinter();
            var phPrint = new PhotoPrinter();
            var photo = new Photo();

            print.Print("Standart");

            cPrint.Print("Colour");
            cPrint.Print("Colour Extend", ConsoleColor.Red);

            phPrint.Print("Photo");
            phPrint.Print(photo);

            Console.ReadLine();
        }
    }
}
