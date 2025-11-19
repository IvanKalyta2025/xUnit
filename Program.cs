
using xUnit.XUNIT;

class Program

{
    static void Main(string[] args)
    {
        var container = new Container<int>();
        container.Add(4);
        container.Add(343);
        container.Add(34);

        for (int i = 0; i < container.Count; i++)
        {
            Console.WriteLine(container.GetAt(i));
        }

        container.Sort((a, b) => b.CompareTo(a)); // Sort in descending order
                                                  // 3 2 1 5
                                                  //   2 3 1 5
                                                  //    2 1 3 5
                                                  //     1 2 3 5 
        Console.WriteLine("After Sorting:");
        var allItems = container.GetAll();
        Console.WriteLine(allItems);

        container.RemoveAt(0); // Remove the first item (which is the largest after sorting)
        Console.WriteLine("After Removing First Item:");

        allItems = container.GetAll();
        Console.WriteLine(allItems);

        container.Clear(); // Clear all items
        Console.WriteLine("After Clearing, Count: " + container.Count);
    }
}




