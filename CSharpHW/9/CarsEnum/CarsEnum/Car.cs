using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsEnum
{
    struct Car
    {
        public string Name { get; set; }
        public Engines EngineName { get; set; }
        public int EngineCapacity { get; set; }
        public Colors Color { get; set; }
        public Transmissions TransmissionType { get; set; }
        public override string ToString()
        {            
            return String.Format("{0} {1} has {2} engine with {3} power and {4} transmission",
                Color, Name, EngineName, EngineCapacity, TransmissionType); ;
        }
    }
}
