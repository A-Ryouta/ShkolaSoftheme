using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintServer;

namespace MassPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer print = new Printer();
            ColourPrinter cPrint = new ColourPrinter();
            PhotoPrinter phPrint = new PhotoPrinter();

            string[] text = { "This", "is", "new", "header", "!" };
            Photo[] photos = { new Photo(), new Photo("+++++"), new Photo("/(/)/"), new Photo("@@@@@@") };

            ExtensionMethods.PrintText(print, text);
            ExtensionMethods.PrintColourText(cPrint, text, ConsoleColor.Yellow);
            ExtensionMethods.PrintPhoto(phPrint, photos);

            Console.ReadLine();
        }
    }
}
