
class Program
{
    public int Add(int num1, int num2)
    {
        Console.WriteLine("Addition with 2 int nums");
        return num1 + num2;
    }

    // overloaded with 3 params
    public int Add(int num1, int num2, int num3)
    {
        Console.WriteLine("Addition with 3 int nums");
        return num1 + num2 + num3;
    }

    // overloaded with 3 params
    public double Add(int num1, int num2, double num3)
    {
        Console.WriteLine("Addition with 2 int and 1 double num(s)");
        return num1 + num2 + num3;
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        p.Add(10, 20);
        Console.WriteLine();
        p.Add(10, 20, 30);
        Console.WriteLine();
        p.Add(10, 20, 30.423);
    }
}
