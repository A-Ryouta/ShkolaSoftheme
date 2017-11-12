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

            current.EngineName = e.ToString();
            current.EngineCapacity = (int)e;
            current.Color = c.ToString();
            current.TransmissionType = tr.ToString();

            return current;
        }

        public Car ReConstruct(Car c, Engines newEngine)
        {
            c.EngineName = newEngine.ToString();
            c.EngineCapacity = (int)newEngine;
            return c;
        }
    }
}
