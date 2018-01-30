using System;

namespace ArrayOperations
{
    internal class FindSoloNumber
    {
        private readonly int[] _checker;
        private int[] _array;

        public FindSoloNumber()
        {
            _checker = new int[1001];

            for (var i = 0; i < 1001; i++)
            {
                _checker[i] = 0;               
            }
        }
        public void Fill()
        {
            _array = new int[1001];
            var rand = new Random();
            var index = 0;

            do
            {
                var buffer = rand.Next(0, 501);

                if (_checker[buffer] == 2) continue;

                _array[index] = buffer;
                index++;
                _checker[buffer]++;

            } while (index < 1001);
        }

        public void Show()
        {
            foreach (var element in _array)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }

        public int Find()
        {
            int count;
            var start = 1;
            var result = _array[0];

            do
            {
                count = 1;

                for (var i = start; i < _array.Length; i++)
                {
                    if (result != _array[i]) continue;

                    var temp = _array[i];
                    _array[i] = _array[start];
                    _array[start] = temp;

                    count++;
                    start += 2;
                    result = _array[start - 1];

                    break;
                }
            } while (count != 1);

            return result;
        }
    }
}
