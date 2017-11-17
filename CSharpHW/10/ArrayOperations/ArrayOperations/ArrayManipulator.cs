using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    class ArrayManipulator
    {
        private int[] _array;       

        public void Generate(int n)
        {
            _array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next(-100, 100);
            }
        }
        public void Show()
        {
            foreach (int element in _array)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
        public void Add(int value)
        {
            int[] buffer = new int[_array.Length];
            for(int i = 0; i < _array.Length; i++)
            { 
                buffer[i] = _array[i];
            }

            _array = new int[buffer.Length + 1];

            for (int i = 0; i < buffer.Length; i++)
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
            foreach(int element in _array)
            {
                if(element == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
