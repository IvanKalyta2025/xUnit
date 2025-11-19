using xUnit.XUNIT;
using System;
using System.Collections.Generic;

namespace xUnit.XUNIT
{

    public class Container<T> : IStorable<T>
    {
        private readonly List<T> _items = new();

        public int Count => _items.Count;

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T GetAt(int index)
        {
            return _items[index];
        }
        public void Clear()
        {
            _items.Clear();
        }
        public IEnumerable<T> GetAll()
        {
            return _items;
        }
        public void Sort(Comparison<T> comparison)
        {
            _items.Sort(comparison);
        }
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}