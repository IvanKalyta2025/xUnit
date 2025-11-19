using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xUnit.XUNIT
{
    public interface IStorable<T>
    {
        int Count { get; }

        T Value { get; }
    }
}