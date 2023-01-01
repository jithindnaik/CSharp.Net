class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }
}

class Amphibian: Animal
{
    public void Swim() {
        Console.WriteLine("Amphibians is Swimming");
    }
}

class Reptile: Amphibian
{
    public void Fly() {
        Console.WriteLine("Reptile is Flying");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        // common characteristics
        Animal a = new Animal();
        a.Eat();
        a.Sleep();

        Console.WriteLine();
        Console.WriteLine();


        // Single level inheritance
        Amphibian b = new Amphibian();
        b.Eat();
        b.Sleep();
        b.Swim();

        Console.WriteLine();
        Console.WriteLine();

        // Multi level inheritance
        Reptile r = new Reptile();
        r.Eat();
        r.Sleep();
        b.Swim();
        r.Fly();
    }
}