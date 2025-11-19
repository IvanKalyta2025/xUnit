using xUnit.XUNIT;
using System;
using System.Collections.Generic;

namespace xUnit.XUNIT
{

    public class Container<T> : IStorable<T>
    {
        public int Count => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public T GetAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}