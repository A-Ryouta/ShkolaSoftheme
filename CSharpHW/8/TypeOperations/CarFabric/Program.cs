using System;

namespace CarFabric
{
    internal class Program
    {
        static void Main()
        {
            var china = new Engine("China", 400);
            var maibah = new Engine("Maibah", 1400);

            var red = new Color("Red");
            var black = new Color("Black");

            var soft = new Transmission("Soft");
            var hard = new Transmission("Hard");

            var mersedes = CarConstructor.Construct(maibah, black, soft);
            mersedes.Name = "Mersedes";
            mersedes.Print();

            var mitsubishi = CarConstructor.Construct(china, red, hard);
            mitsubishi.Name = "Mitsubishi";
            mitsubishi.Print();

            CarConstructor.Reconstruct(mitsubishi);
            mitsubishi.Print();

            Console.ReadLine();
        }
    }
}
