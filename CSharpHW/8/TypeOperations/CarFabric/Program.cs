using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFabric
{
    class Program
    {
        static void Main(string[] args)
        {
            var china = new Engine("China", 400);
            var maibah = new Engine("Maibah", 1400);

            var red = new Color("Red");
            var black = new Color("Black");

            var soft = new Transmission("Soft");
            var hard = new Transmission("Hard");

            Car mersedes = CarConstructor.Construct(maibah, black, soft);
            mersedes.Name = "Mersedes";
            mersedes.Print();

            Car mitsubishi = CarConstructor.Construct(china, red, hard);
            mitsubishi.Name = "Mitsubishi";
            mitsubishi.Print();

            CarConstructor.Reconstruct(mitsubishi);
            mitsubishi.Print();

            Console.ReadLine();
        }
    }
    internal class Car
    {
        public string Name { get; set; }
        public string EngineMark { get; set; }
        public int EngineCapacity { get; set; }
        public string Color { get; set; }
        public string TransmissionType { get; set; }
        public Car()
        { }
        public Car(string _name)
        {
            Name = _name;
        }
        public void Print()
        {
            Console.WriteLine("{0} {1} has {2} engine with {3} power and {4} transmission",
                Color, Name, EngineMark, EngineCapacity, TransmissionType);
        }
    }
    internal static class CarConstructor
    {
        public static Car Construct(Engine e, Color c, Transmission tr)
        {
            var current = new Car();            
            current.EngineMark = e.Mark;
            current.EngineCapacity = e.Capacity;
            current.Color = c.ColorName;
            current.TransmissionType = tr.Type;
            return current;
        }
        public static void Reconstruct(Car c)
        {
            c.EngineMark = "Yamaha";
            c.EngineCapacity = 800;
        }
    }
    internal class Engine
    {
        public string Mark { get; set; }
        public int Capacity { get; set; }
        public Engine(string _mark, int _cap)
        {
            Mark = _mark;
            Capacity = _cap;
        }
    }
    internal class Color
    {
        public string ColorName { get; set; }
        public Color(string _color)
        {
            ColorName = _color;
        }
    }
    internal class Transmission
    {
        public string Type { get; set; }
        public Transmission(string _type)
        {
            Type = _type;
        }
    }    

}
