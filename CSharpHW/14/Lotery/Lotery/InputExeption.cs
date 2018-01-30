using System;

namespace Lotery
{
    internal class InputExeption : Exception
    {
        public override string Message { get; }

        public InputExeption(string message)
        {
            Message = message;
        }
    }
}
