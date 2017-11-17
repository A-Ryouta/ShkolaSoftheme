using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    class FindTask
    {
        private int[] checker;
        private int[] _array;

        public FindTask()
        {
            checker = new int[1001];
            for (int i = 0; i < 1001; i++)
            {
                checker[i] = 0;               
            }
        }
        public void Fill()
        {
            _array = new int[1001];
            Random rand = new Random();
            var index = 0;
            var buffer = -1;
            do
            {
                buffer = rand.Next(0, 501);
                if(checker[buffer] != 2)
                {
                    _array[index] = buffer;
                    index++;
                    checker[buffer]++;
                }
            } while (index < 1001);
        }
        public void Show()
        {
            foreach (int element in _array)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
        public int Find()
        {
            var start = 1;
            int count;
            int temp;
            var result = _array[0];

            do
            {
                count = 1;
                for (int i = start; i < _array.Length; i++)
                {
                    if(result == _array[i])
                    {
                        temp = _array[i];
                        _array[i] = _array[start];
                        _array[start] = temp;

                        count++;
                        start += 2;
                        result = _array[start - 1];

                        break;
                    }
                }
            } while (count != 1);

            return result;
        }
    }
}
