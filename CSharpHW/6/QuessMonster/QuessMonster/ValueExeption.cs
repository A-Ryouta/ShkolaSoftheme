using System;

namespace QuessMonster
{
    public class ValueExeption : Exception
    {
        public override string Message { get; } = "Number must be from 1 to 10";
    }
    
}
