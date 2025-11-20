using Xunit;
using xUnit.XUNIT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUNIT.Tests
{
public class ContainerTests
{
[Fact]
public void Add_AddsItemAndUpdatesCount()
{
var container = new Container<int>();

            container.Add(10);

            Assert.Equal(1, container.Count);
            Assert.Equal(10, container.GetAt(0));
        }

        [Fact]
        public void GetAt_ReturnsExpectedItem()
        {
            var container = new Container<string>();
            container.Add("alpha");
            container.Add("beta");

            Assert.Equal("alpha", container.GetAt(0));
            Assert.Equal("beta", container.GetAt(1));
        }

        [Fact]
        public void GetAll_ReturnsAllItemsInInsertionOrder()
        {
            var container = new Container<int>();
            container.Add(2);
            container.Add(5);
            container.Add(7);

            var items = container.GetAll();

            Assert.Equal(new[] { 2, 5, 7 }, items);
        }

        [Fact]
        public void RemoveAt_RemovesItemAndShiftsRemaining()
        {
            var container = new Container<int>();
            container.Add(1);
            container.Add(2);
            container.Add(3);

            container.RemoveAt(1);

            Assert.Equal(2, container.Count);
            Assert.Equal(new[] { 1, 3 }, container.GetAll());
        }

        [Fact]
        public void Sort_UsesProvidedComparison()
        {
            var container = new Container<int>();
            container.Add(3);
            container.Add(1);
            container.Add(2);

            container.Sort((a, b) => b.CompareTo(a)); // sort descending

            Assert.Equal(new[] { 3, 2, 1 }, container.GetAll());
        }

        [Fact]
        public void Clear_RemovesAllItems()
        {
            var container = new Container<int>();
            container.Add(42);
            container.Add(100);

            container.Clear();

            Assert.Equal(0, container.Count);
            Assert.Empty(container.GetAll());
        }
    }

}
