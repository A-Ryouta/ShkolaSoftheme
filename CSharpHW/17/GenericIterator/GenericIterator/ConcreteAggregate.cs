using System.Collections.Generic;

namespace GenericIterator
{
    class ConcreteAggregate<T> : IAggregate<T>
    {
        private  readonly List<T> _items = new List<T>();

        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        public int Count => _items.Count;

        public T this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }

    }
}
