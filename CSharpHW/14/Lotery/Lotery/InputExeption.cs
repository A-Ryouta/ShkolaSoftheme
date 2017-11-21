using System;

namespace Lotery
{
    class InputExeption : Exception
    {
        public override string Message { get; }

        public InputExeption(string message)
        {
            Message = message;
        }
    }
}
