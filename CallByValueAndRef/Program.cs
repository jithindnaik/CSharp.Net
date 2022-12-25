class MethodCall
{
    public void callByValue(int val)
    {
        val += 10;
        Console.WriteLine($"Value in the calling fun() {val}");
    }

    public void callByReference(ref int val)
    {
        val += 10;
        Console.WriteLine($"Value in the calling fun() {val}");
    }

    public void outParmeter(out int val3, out int val4)
    {
        val3 = 10;
        val4 = 20;
        val3 += 10;
        val4 += 20;
        Console.WriteLine($"Value in the calling fun() {val3}, {val4}");
    }

    public static void Main(string[] args)
    {
        int val = 100;

        MethodCall m = new MethodCall();
        Console.WriteLine($"Value before the calling fun() {val}");
        m.callByValue(val);
        Console.WriteLine($"Value after calling fun() {val}");

        int val1 = 200;
        m.callByReference(ref val1);
        Console.WriteLine($"Value after calling fun() {val1}");

        int val3;
        int val4;
        m.outParmeter(out val3, out val4);
        Console.WriteLine($"Value after calling fun() {val3}, {val4}");
    }
}