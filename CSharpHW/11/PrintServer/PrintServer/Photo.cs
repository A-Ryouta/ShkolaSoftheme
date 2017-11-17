using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintServer
{
    public class Photo
    {
        public string Photograph { get; private set; }
        public Photo()
        {
            Photograph = "*****";
        }
        public Photo(string p)
        {
            Photograph = p;
        }        
    }
}
