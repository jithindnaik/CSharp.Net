class Person
{
    public virtual void Action()
    {
        Console.WriteLine("Person is Walking !!!");
    }
}

class Person1: Person
{
    public override void Action()
    {
        Console.WriteLine("Person is Sitting !!!");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Person1 p = new Person1();
        p.Action();
    }
}

