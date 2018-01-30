using System;

namespace Lotery
{
    internal class Number
    {
        private static readonly Random Rnd = new Random();
        public readonly int number;

        public Number()
        {
            number = Rnd.Next(1, 9);
        }
    }
}
