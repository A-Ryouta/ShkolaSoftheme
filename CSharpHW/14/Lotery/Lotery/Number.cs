using System;

namespace Lotery
{
    class Number
    {
        private Random rnd = new Random();
        public readonly int number;

        public Number()
        {
            number = rnd.Next(1, 9);
        }
    }
}
