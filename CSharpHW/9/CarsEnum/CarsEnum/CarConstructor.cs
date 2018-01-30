namespace CarsEnum
{
    internal class CarConstructor
    {
        public Car CarConstruct(Engines e, Colors c, Transmissions tr)
        {
            var current = new Car
            {
                EngineName = e,
                EngineCapacity = (int) e,
                Color = c,
                TransmissionType = tr
            };

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
