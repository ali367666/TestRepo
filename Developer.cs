namespace ConsoleApp13;

public class Developer:Person
{
    public override void GetInfo()
    {
        Console.WriteLine($"Developer Name-{Name},Developer Surname-{Surname}");
    }
}
