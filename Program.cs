
using xUnit.XUNIT;

class Program

{
    static void Main(string[] args)
    {
        var container = new Container<int>();
        container.Add(1);
        container.Add(2);
        container.Add(3);

        for (int i = 0; i < container.Count; i++)
        {
            Console.WriteLine(container.GetAt(i));
        }
    }
}