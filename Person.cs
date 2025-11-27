namespace ConsoleApp13;

public class Person
{
    public  string Name { get; set; }
    public string Surname { get; set; }
    public virtual void GetInfo()
    {
        Console.WriteLine($"{Name}-{Surname}");
        Console.WriteLine("Salam yeni proje testi");
    }
}
