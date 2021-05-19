using System;
using System.Collections;

namespace task02
{
    public class MyList<T> : IEnumerable, IEnumerator
    {
        private T[] _items;
        private int _position = -1;

        public MyList(T[] items)
        {
            _items = items;
        }

        public void Add(T item)
        {
            Array.Resize(ref _items, Length + 1);
            _items[Length - 1] = item;
        }

        public T this[int index] => _items[index];

        public int Length => _items.Length;

        public bool MoveNext()
        {
            if (_position < _items.Length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current => _items[_position];

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}