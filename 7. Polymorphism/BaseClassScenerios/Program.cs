class Animal 
{
    public string animalName = "";

    public void Action()
    {
        Console.WriteLine("Animal is sitting");
    }

    public Animal()
    {
        Console.WriteLine("Animal constructor is invoked.");
    }
}

class Panda: Animal
{
    public string animalName = "Panda";

    public void Action()
    {
        Console.WriteLine("Animal is standing");
    }

    public void invokeBaseClassEntities()
    {
        Console.WriteLine();
        base.Action();
        this.animalName = base.animalName;
        Console.WriteLine($"Animal name: {this.animalName}");
    }
}



class Program
{
    static void Main(string[] args)
    {
        Panda p = new Panda();
        p.invokeBaseClassEntities();
    }
}