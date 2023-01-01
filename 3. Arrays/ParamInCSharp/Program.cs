class ParamsInCSharp
{
    public void printIntParms(params int[] arr)
    {
        for (int i = 0; i< arr.Length; i++)
        {
            Console.WriteLine($"{arr[i]} ");
        }
    }

    public void printObjParms(params object[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"{arr[i]} ");
        }
    }

    public static void Main(string[] args)
    {
        ParamsInCSharp pcsharp = new ParamsInCSharp();
        pcsharp.printIntParms(1, 2, 3, 4, 5, 6, 7, 8);
        Console.WriteLine();
        pcsharp.printObjParms(1, 2, 3, 4, 5, "Hii", "Hello");
    }
}