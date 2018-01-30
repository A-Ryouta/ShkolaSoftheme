using System;

namespace CarFabric
{
    internal class Car
    {
        public string Name { get; set; }
        public string EngineMark { get; set; }
        public int EngineCapacity { get; set; }
        public string Color { get; set; }
        public string TransmissionType { get; set; }

        public Car()
        { }

        public Car(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine("{0} {1} has {2} engine with {3} power and {4} transmission",
                Color, Name, EngineMark, EngineCapacity, TransmissionType);
        }
    }
}
