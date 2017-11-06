using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Model = "BMV";
            car.Year = 1998;
            car.Color = "Blue";
            Console.WriteLine("Color: {0}", car.Color);

            TuninngAtelier.TuneCar(car);
            Console.WriteLine("Color: {0}", car.Color);

            Console.ReadLine();
        }
    }

    internal class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    internal static class TuninngAtelier
    {
        internal static void TuneCar(Car c)
        {
            c.Color = "Red";
        }
    }
}
