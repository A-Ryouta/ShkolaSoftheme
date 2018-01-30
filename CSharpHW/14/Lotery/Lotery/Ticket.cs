namespace Lotery
{
    internal class Ticket
    {
        private readonly Number[] _combination;
        
        public Number this[int index] => _combination[index];

        public Ticket()
        {
            _combination = new Number[6];

            for (var i = 0; i < _combination.Length; i++)
            {
                _combination[i] = new Number();
            }
        }
    }
}
