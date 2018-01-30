namespace CarsEnum
{
    internal struct Car
    {
        public string Name { get; set; }
        public Engines EngineName { get; set; }
        public int EngineCapacity { get; set; }
        public Colors Color { get; set; }
        public Transmissions TransmissionType { get; set; }

        public override string ToString()
        {            
            return
                $"{Color} {Name} has {EngineName} engine with {EngineCapacity} power and {TransmissionType} transmission";
        }
    }
}
