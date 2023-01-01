class IfStatementLearning
{
    public static void Main(string[] args)
    { 
        int userInput;
        Console.WriteLine("Please enter Heads/Tails, denoted by (0: Heads,1: Tails)");
        userInput = Int32.Parse(Console.ReadLine());
        string userInputMatchTextTemplate = "User Input matches: {0}";

        // if else
        //if (userInput.Equals(1))
        //{
        //    Console.WriteLine(userInputMatchTextTemplate, "Tails");
        //} else
        //{
        //    Console.WriteLine(userInputMatchTextTemplate, "Heads");
        //}

        // terinary condition
        //string text = userInput.Equals(1) ? "Tails" : "Heads";
        //Console.WriteLine(userInputMatchTextTemplate, text);


        if (userInput.Equals(1))
        {
            Console.WriteLine(userInputMatchTextTemplate, "Tails");
        } else if (userInput.Equals(0))
        {
            Console.WriteLine(userInputMatchTextTemplate, "Heads");
        } else
        {
            Console.WriteLine(userInputMatchTextTemplate, "Invalid Input entered");
        }
    }
}

