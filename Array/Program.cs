class CSharpArray
{
    public static void Main(string[] args)
    {
        // initialize with size
        int[] array = new int[5] { 1, 2, 3, 4, 5 };

        // initialize directly
        int[] array2 = { 1, 2, 3, 4, 5 };

        // initialize without size
        int[] array3 = new int[]{ 1, 2, 3, 4, 5 };

        int[] array4 = new int[5];
        array4[0] = 1;
        array4[2] = 2;
        array4[4] = 3;

        for (int i=0; i< array4.Length; i++)
        {
            Console.WriteLine(array4[i]);
        }
    }
}