﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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