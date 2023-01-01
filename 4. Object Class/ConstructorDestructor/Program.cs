using System;

public class ConstructorInClass
{
    string name;
    int age;

    // Class constructor
    public ConstructorInClass(string name, int age)
    {
        Console.WriteLine("Class Constructor invoked.");
        this.name = name;
        this.age = age;
    }

    // Class destructor
    ~ConstructorInClass()
    {
        Console.WriteLine("Class Destructor invoked.");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        ConstructorInClass cc = new ConstructorInClass("Jithin", 34);
        

        ConstructorInClass cc1 = new ConstructorInClass("Amritha", 26);
    }
}