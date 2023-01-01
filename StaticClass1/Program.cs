class Program
{
    int id;
    static string name;

    Program()
    {
        Console.WriteLine("Normal Constructor");
        id = 0;
        name = "Default name";
    }

    static Program()
    {
        Console.WriteLine("Static Constructor");
        name = "static name";
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine(p.id);
        Console.WriteLine(Program.name);


    }
}

