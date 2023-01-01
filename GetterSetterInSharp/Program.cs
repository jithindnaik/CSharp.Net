class GetterSetter
{
    static int _counter = 0;

    GetterSetter()
    {
        _counter++;
    }

    // string name = "";
    //public string Name
    //{
    //    get
    //    {
    //        return this.name;
    //    }
    //    set
    //    {
    //        this.name = value;
    //    }
    //}

    // Short syntax
    public string? Name
    {
        get; set;
    }

    public static int Counter {
        get
        {
            return _counter;
        }
        set
        {
            _counter = value;
        }
    }

    public static void Main(string[] args)
    {
        GetterSetter gs = new GetterSetter();
        gs.Name = "Jithin";

        Console.WriteLine(gs.Name);
        Console.WriteLine(GetterSetter.Counter);
    }
}
