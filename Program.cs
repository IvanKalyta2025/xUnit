
using Microsoft.VisualBasic;

public interface BoxBox
{
    int Count(int num1, int num2);
    void Run();


}


public class Box<T> : BoxBox
{
    public required T Content { get; set; }

    public int Count(int num1, int num2)
    {
        int feber = num1 + num2;
        return feber;
    }

    public void Run()
    {
        Console.WriteLine(Content);
    }
}

class Program
{
    static void Main()
    {

        var intBox = new Box<string> { Content = "Danylo" };
        var intBoxBool = new Box<bool> { Content = true };

        intBox.Run();
        intBoxBool.Run();
        intBox.Count(2, 12);
    }

}




