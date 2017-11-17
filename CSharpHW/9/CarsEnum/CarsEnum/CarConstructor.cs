using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsEnum
{
    class CarConstructor
    {
        public Car CarConstruct(Engines e, Colors c, Transmissions tr)
        {
            var current = new Car();

            current.EngineName = e;
            current.EngineCapacity = (int)e;
            current.Color = c;
            current.TransmissionType = tr;

            return current;
        }

        public Car ReConstruct(Car c, Engines newEngine)
        {
            c.EngineName = newEngine;
            c.EngineCapacity = (int)newEngine;
            return c;
        }
    }
}
