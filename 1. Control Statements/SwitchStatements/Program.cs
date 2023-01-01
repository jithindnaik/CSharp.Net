class SwitchStatements
{
    public static void Main(string[] args)
    {
        int dayChoice;
        Console.WriteLine("Please enter the day choice as number(1: SUN, 2: MON, 3: TUE, 4: WED, 5: THU, 6: FRI, 7: SAT)");
        dayChoice = Int32.Parse(Console.ReadLine());

        string day = "";
        switch(dayChoice)
        {
            case 1:
                day = "SUN";
                break;
            case 2:
                day = "MON";
                break;
            case 3:
                day = "TUE";
                break;
            case 4:
                day = "WED";
                break;
            case 5:
                day = "THU";
                break;
            case 6:
                day = "FRI";
                break;
            case 7:
                day = "SAT";
                break;
            default:
                day = "Invalid user input";
                break;
        }

        Console.WriteLine($"Entered day choice in string is : {day}");
    }
}
