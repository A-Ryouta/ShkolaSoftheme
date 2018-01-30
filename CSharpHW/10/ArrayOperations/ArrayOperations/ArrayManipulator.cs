using System;
using System.Linq;

namespace ArrayOperations
{
    internal class ArrayManipulator
    {
        private int[] _array;       

        public void Generate(int n)
        {
            _array = new int[n];
            var rand = new Random();

            for (var i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next(-100, 100);
            }
        }

        public void Show()
        {
            foreach (var element in _array)
            {
                Console.Write("{0} ", element);
            }

            Console.WriteLine();
        }

        public void Add(int value)
        {
            var buffer = new int[_array.Length];

            for(var i = 0; i < _array.Length; i++)
            { 
                buffer[i] = _array[i];
            }

            _array = new int[buffer.Length + 1];

            for (var i = 0; i < buffer.Length; i++)
            {
                _array[i] = buffer[i];
            }

            _array[_array.Length - 1] = value;
        }

        public int GetByIndex(int index)
        {
            return _array[index];
        }

        public bool Contains(int value)
        {
            return _array.Any(element => element == value);
        }
    }
}
