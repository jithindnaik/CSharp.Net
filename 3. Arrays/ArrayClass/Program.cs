class ArrayClass
{
    public static void Main(string[] args)
    {
        ArrayClass arrc = new ArrayClass();

        string[] arr  = new String[5] { "ram", "sita", "lakshman", "hari", "vishnu" };
        string[] arr1 = new String[2] { "ramu", "jithu" };
        string[] arr3 = new string[5];

        Console.WriteLine("Reverse of array is :");
        arr.Reverse();

        Console.WriteLine("Length of array is :");
        Console.WriteLine(arr.Length);

        Console.WriteLine("Copy of array is :");
        Array.Copy(arr, arr3, arr3.Length);

        Console.WriteLine("Sort of array is :");
        Array.Sort(arr);

        Console.WriteLine("Reverse of array is :");
        Array.Reverse(arr);

        Console.WriteLine("Clear of array is :");
        Array.Clear(arr);

        // NOTE: Before invoking the binary search the arr should be sorted.

        //Console.WriteLine("Binary Search in array:");
        string[] arr5 = new String[5] { "ram", "sita", "lakshman", "hari", "vishnu" };
        Array.Sort(arr5);
        int index = Array.BinarySearch(arr5, "www");
        if (index < 0)
        {
            Console.WriteLine("Binary Search ele not found.");
        } else
        {
            Console.WriteLine($"Binary Search ele found - '{arr5[index]}' at index {index}");
        }

        // arrc.PrintArray(arr);

        // arrc.PrintArray(arr1);

        //Console.WriteLine(arr.ToString());
    }

    public void PrintArray(string[] arr)
    {
        foreach(string el in arr)
        {
            Console.WriteLine(el);
        }
    }
}
