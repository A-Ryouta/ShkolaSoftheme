namespace DoubleLinkedList
{
    internal class DoubleLinkedList<T>
    {
        private ListItem<T> _first;
        private ListItem<T> _last;

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            var item = new ListItem<T>(value);

            if (_first == null)
            {
                _first = item;
                _last = item;
            }
            else
            {
                _first.Previous = item;
                 item.Next = _first;
                _first = item;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            var item = new ListItem<T>(value);

            if (_first == null)
            {
                _first = item;
                _last = item;
            }
            else
            {
                _last.Next = item;
                item.Previous = _last;
                _last = item;
            }

            Count++;
        }

        public bool Remove(T item)
        {
            ListItem<T> previous = null;
            var current = _first;
            ListItem<T> next = null;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null && next != null)
                    {
                        previous.Next = current.Next;
                        next.Previous = current.Previous;
                    }
                    else if (previous != null)
                    {
                        previous.Next = current.Next;
                        _last = previous;
                    }
                    else
                    {
                        _first = _first.Next;

                        if (_first == null)
                        {
                            _last = null;
                        }
                    }

                    Count--;

                    return true;
                }

                previous = current;
                current = current.Next;
                next = current.Next;
            }

            return false;
        }

        public bool Contains(T item)
        {
            var current = _first;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }
            return false;
        }

        public T[] ToArray()
        {
            var current = _first;
            var array = new T[Count];

            for(var i = 0; i < Count; i++)
            {
                array[i] = current.Value;
                current = current.Next;
            }
            return array;
        }
    }
}
