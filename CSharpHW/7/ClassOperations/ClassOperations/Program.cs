using System;


namespace ClassOperations
{
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.Model = "BMV";
            car.Year = 1998;
            car.Color = "Blue";
            Console.WriteLine("Color: {0}", car.Color);

            TunningAtelier.TuneCar(car);
            Console.WriteLine("Color: {0}", car.Color);

            Console.ReadLine();
        }
    }
    
}
