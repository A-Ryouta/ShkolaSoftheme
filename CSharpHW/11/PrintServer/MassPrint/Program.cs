using System;
using PrintServer;

namespace MassPrint
{
    internal class Program
    {
        private static void Main()
        {
            var print = new Printer();
            var cPrint = new ColourPrinter();
            var phPrint = new PhotoPrinter();

            string[] text = { "This", "is", "new", "header", "!" };
            Photo[] photos = { new Photo(), new Photo("+++++"), new Photo("/(/)/"), new Photo("@@@@@@") };

            print.PrintText(text);
            cPrint.PrintColourText(text, ConsoleColor.Yellow);
            phPrint.PrintPhoto(photos);

            Console.ReadLine();
        }
    }
}
