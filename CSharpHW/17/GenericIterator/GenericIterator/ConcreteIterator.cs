namespace GenericIterator
{
    class ConcreteIterator<T> : IIterator<T>
    {
        private int _current;
        private readonly ConcreteAggregate<T> _aggregate;

        public ConcreteIterator(ConcreteAggregate<T> aggregate)
        {
            _aggregate = aggregate;
        }

        public T First()
        {
            return _aggregate[0];
        }

        public T Next()
        {
            T ret = default(T);
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        public T CurrentItem()
        {
            return _aggregate[_current];
        }

        public bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
}
