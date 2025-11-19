using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xUnit.XUNIT
{
    public interface IStorable<T>
    {
        int Count { get; }
        void Add(T item);
        T GetAt(int index);

        void Clear();
        IEnumerable<T> GetAll();
        void RemoveAt(int index);
        void Sort(Comparison<T> comparison);

    }
}