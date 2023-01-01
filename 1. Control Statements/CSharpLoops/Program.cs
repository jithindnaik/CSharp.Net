class Loop
{
    public static void Main(string[] args)
    {
        // for loop
        //for (var i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        // nested for loop
        //for (var i = 0; i <= 10; i++)
        //{
        //    for (var j = i; j <= 10; j++)
        //    {
        //        Console.WriteLine($"i: {i} j: {j}");
        //    }
        //}

        // var i = 0;
        // var j = 0;
        // while(i<=10)
        // {
        //     while(j<=10)
        //     {
        //         Console.WriteLine($"i: {i} j: {j}");
        //         j++;
        //     }
        //     j = 0;
        //     i++;
        //}

        var i = 0;
        var j = 0;
        do
        {
            while (j <= 10)
            {
                Console.WriteLine($"i: {i} j: {j}");
                j++;
            }
            j = 0;
            i++;
        } while (i <= 10);
    }
}