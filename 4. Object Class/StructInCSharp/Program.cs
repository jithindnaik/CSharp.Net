// struct does not support inheritance but can support interface. Its lightweight object
struct Program
{
    string name;
    int age;

    public Program()
    {
        this.name= "Default name";
        this.age = 0;

    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine(p.age);
    }
} 
