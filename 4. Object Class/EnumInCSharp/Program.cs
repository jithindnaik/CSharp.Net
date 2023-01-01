class Program
{
    public enum Colors: byte
    {
        RED = 1,
        YELLOW = 2,
        GREEN = 3,
        BLUE = 4,
        ORANGE = 5
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Colors.BLUE);

        Console.WriteLine((int)Colors.BLUE);
    }
}
