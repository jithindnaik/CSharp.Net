class JaggedArray
{
    public void printJaggedArray(int[][] arr)
    {
        for(int i=0; i< arr.Length; i++)
        {
            for(int j=0; j< arr[i].Length; j++)
            {
                Console.Write($"{arr[i][j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        JaggedArray ja = new JaggedArray();

        int[][] arr = new int[2][] {
            new int[]{1, 2 },
            new int[]{3, 4}
        };

        int[][] arr1 = new int[2][];
        arr1[0] = new int[]{1,2};
        arr1[1] = new int[] { 3, 4 };

        ja.printJaggedArray(arr);
    }
}

