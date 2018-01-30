namespace CarFabric
{
    internal static class CarConstructor
    {
        public static Car Construct(Engine engine, Color color, Transmission transmission)
        {
            var current = new Car
            {
                EngineMark = engine.Mark,
                EngineCapacity = engine.Capacity,
                Color = color.ColorName,
                TransmissionType = transmission.Type
            };
            
            return current;
        }

        public static void Reconstruct(Car car)
        {
            car.EngineMark = "Yamaha";
            car.EngineCapacity = 800;
        }
    }
}
