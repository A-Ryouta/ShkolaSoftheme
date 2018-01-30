using System;

namespace PrintServer
{
    public class Printer
    {
        public virtual void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
