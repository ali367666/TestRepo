namespace ConsoleApp13;

public class Manager:Person
{
    public override void GetInfo()
    {
        Console.WriteLine($"Manager name:{Name},Manager surname:{Surname}");
    }
}
