class MinMaxInArray
{

    public int GetMaxInArray(int[] arr)
    {
        int minItem = arr[0];
        for (var i =0; i< arr.Length; i++)
        {
            if (arr[i] < minItem)
            {
                minItem = arr[i];
            }
        }
        return minItem;
    }

    public int GetMinInArray(int[] arr)
    {
        int minItem = arr[0];
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] > minItem)
            {
                minItem = arr[i];
            }
        }
        return minItem;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        MinMaxInArray mm = new MinMaxInArray();
        int min = mm.GetMaxInArray(arr);
        int max = mm.GetMinInArray(arr);

        Console.WriteLine($"Min item in the array: {min}");
        Console.WriteLine($"Min item in the array: {max}");
    }
}