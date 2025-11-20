using Xunit;
using xUnit.XUNIT;

namespace XUNIT.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_ShouldIncreaseCount()
    {
        var container = new Container<int>();

        container.Add(5);

        Assert.Equal(1, container.Count);
        Assert.Equal(5, container.GetAt(0));
    }

    [Fact]
    public void GetAll_ShouldReturnItemsInInsertionOrder()
    {
        var container = new Container<string>();
        container.Add("one");
        container.Add("two");

        var items = container.GetAll();

        Assert.Equal(new[] { "one", "two" }, items);
    }

    [Fact]
    public void RemoveAt_ShouldRemoveItemAndShiftRest()
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
    public void Sort_ShouldUseCustomComparison()
    {
        var container = new Container<int>();
        container.Add(10);
        container.Add(1);
        container.Add(5);

        container.Sort((a, b) => a.CompareTo(b));

        Assert.Equal(new[] { 1, 5, 10 }, container.GetAll());
    }

    [Fact]
    public void Clear_ShouldRemoveAllItems()
    {
        var container = new Container<int>();
        container.Add(42);
        container.Add(33);

        container.Clear();

        Assert.Equal(0, container.Count);
        Assert.Empty(container.GetAll());
    }
}

