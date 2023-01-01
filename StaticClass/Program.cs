static class StaticClass
{
    static string name;
    static int age;

    static StaticClass()
    {
        name = "Default Name";
        age = 0;
    }

    static void printEntities()
    {
        Console.WriteLine($"Name: {StaticClass.name}");
        Console.WriteLine($"Age: {StaticClass.age}");
    }

    public static void Main(string[] args)
    {
        // StaticClass.name = "Jithin";
        StaticClass.printEntities();
    }
}

