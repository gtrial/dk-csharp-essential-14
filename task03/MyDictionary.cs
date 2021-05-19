#nullable enable
using System;
using System.Collections;

namespace task03
{
    public class MyDictionary<TKey, TValue> : IEnumerable, IEnumerator
    {
        private TKey[] _keys;
        private TValue[] _values;
        private int _position = -1;

        public MyDictionary(TKey[] keys, TValue[] values)
        {
            _keys = keys;
            _values = values;
        }

        public void Add(TKey key, TValue value)
        {
            Array.Resize(ref _keys, _keys.Length + 1);
            _keys[^1] = key;
            Array.Resize(ref _values, _values.Length + 1);
            _values[^1] = value;
        }

        public TValue this[int index] => _values[index];

        public int Length => _keys.Length;

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_position < _keys.Length - 1)
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

        public object? Current => _keys[_position];
    }
}