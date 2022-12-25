class MultiDimensionArray
{

    public static void Main(string[] args)
    {
        MultiDimensionArray ma = new MultiDimensionArray();

        // initializing multi-dimension array - method 1
        int[,] arr = new int[3,2]{ { 1, 2 },{ 3, 4 },{ 5, 6 } };
        for (var i=0; i< 3; i++)
        {
            for (var j=0; j< 2; j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();

        // initializing multi-dimension array - method 2
        int[,] arr1 = new int[2,2] {{ 1, 2 }, {3,4}};
        for (var i = 0; i < 2; i++)
        {
            for (var j = 0; j < 2; j++)
            {
                Console.Write($"{arr1[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();

        // initializing multi-dimension array - method 3
        int[,] arr2 = new int[,] { { 1, 2 } };
        for (var i = 0; i < 1; i++)
        {
            for (var j = 0; j < 2; j++)
            {
                Console.Write($"{arr2[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}