class CommandLineArgs
{
    public static void Main(string[] args)
    {
        Console.ReadKey();
        CommandLineArgs cmdArgs = new CommandLineArgs();
        cmdArgs.printCommandLineArgs(args);
    }

    public void printCommandLineArgs(string[] args)
    {
        foreach(string arg in args)
        {
            Console.WriteLine($"Arg: {arg}");
        }
    }
}