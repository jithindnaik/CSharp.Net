// Sealed can be applied only to Class and Methods.

// Adding a Class as sealed keyword will prevent from further level of inheritance
public class Animal
{
    public string voice = "meow";
    public virtual void Action()
    {
        Console.WriteLine("Animal is Walking");
    }
}

class Cat: Animal
{
    public sealed override void Action()
    {
        Console.WriteLine("Cat is Walking");
    }
}

class PuppyCat: Cat
{
    // The below function will not work as the Cat has selaled keyword which prevents from further overrides
    //public override void Action()
    //{
    //    Console.WriteLine("PuppyCat is Walking");
    //}
}

class Program
{
    public static void Main(string[] args)
    {
        PuppyCat pc = new PuppyCat();
        pc.Action();
    }
}