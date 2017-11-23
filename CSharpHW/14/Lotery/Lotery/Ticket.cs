namespace Lotery
{
    class Ticket
    {
        readonly Number[] _combination;

        public Ticket()
        {
            
        }

        public Number this[int index]
        {
            get
            {
                return _combination[index];
            }
        }

        private void Initiate()
        {
            _combination = new Number[6];
            for (int i = 0; i < _combination.Length; i++)
            {
                _combination[i] = new Number();
            }
        }
    }
}
