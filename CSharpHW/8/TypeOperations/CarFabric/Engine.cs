namespace CarFabric
{
    internal class Engine
    {
        public string Mark { get; }
        public int Capacity { get; }

        public Engine(string mark, int cap)
        {
            Mark = mark;
            Capacity = cap;
        }
    }
}
