using System;
using PrintServer;

namespace MassPrint
{
    public static class ExtensionMethods
    {
        public static void PrintText(this Printer printer, string[] text)
        {
            foreach(var s in text)
            {
                printer.Print(s);
            }
        }

        public static void PrintColourText(this ColourPrinter printer, string[] text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (var s in text)
            {
                printer.Print(s);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void PrintPhoto(this PhotoPrinter printer, Photo[] photos)
        {
            foreach (var photo in photos)
            {
                printer.Print(photo);
            }
        }
    }
}
