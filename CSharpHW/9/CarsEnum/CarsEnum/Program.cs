﻿using System;

namespace CarsEnum
{
    internal class Program
    {
        private static void Main()
        {
            var construction = new CarConstructor();

            var bmv = construction.CarConstruct(Engines.NissanEJ3, Colors.Red, Transmissions.Mechanic);
            bmv.Name = "BMV";

            var audi = construction.CarConstruct(Engines.ToyotaFE, Colors.Silver, Transmissions.Automantic);
            audi.Name = "Audi";

            var mersedes = construction.CarConstruct(Engines.SubaruSR, Colors.Black, Transmissions.Robotics);
            mersedes.Name = "Mersedes";

            Console.WriteLine("{0}\n{1}\n{2}", bmv, audi, mersedes);

            bmv = construction.ReConstruct(bmv, Engines.Mazda2TE);
            Console.WriteLine(bmv);

            Console.ReadLine();
        }
    }
}
