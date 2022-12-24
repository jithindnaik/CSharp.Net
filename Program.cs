class PrimeNumber
{

    public int GetRangeUntil()
    {
        int numChoice;
        Console.WriteLine("Enter the range of number to display for prime starting from 0");
        numChoice = Int32.Parse(s: Console.ReadLine());
        return numChoice;
    }

    public int GetUserInputNumber()
    {
        int numChoice;
        Console.WriteLine("Enter the number to be checked for Prime");
        numChoice = Int32.Parse(s: Console.ReadLine());
        return numChoice;
    }

    public bool CheckNumberIsPrimeOrNot(int number)
    {
        bool isPrime = true;
        if (number.Equals(1) || number.Equals(0))
        {
            isPrime = false;
        }
        else
        {
            var factor = Convert.ToInt32(number / 2);

            for (var i = 1; i <= factor; i++)
            {
                if (factor == 1)
                {
                    isPrime = true;
                    break;
                }
                if ((number % 2) == 0 || (number % 3) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        return isPrime;
    }
}


class Program: PrimeNumber
{
    public static void Main(string[] args)
    {
        //PrimeNumber p = new PrimeNumber();
        //int numberEntered = p.GetUserInputNumber();
        //bool isPrimeNumber = p.CheckNumberIsPrimeOrNot(numberEntered);

        //if (isPrimeNumber)
        //{
        //    Console.WriteLine($"Number {numberEntered} is PrimeNumber");
        //} else
        //{
        //    Console.WriteLine($"Number {numberEntered} is not a PrimeNumber");
        //}

        PrimeNumber p = new PrimeNumber();
        int numberRange = p.GetRangeUntil();

        for (var range=0; range < numberRange; range++)
        {
            if (p.CheckNumberIsPrimeOrNot(range))
            {
                Console.WriteLine($"Number {range} is PrimeNumber");
            }
            else
            {
                Console.WriteLine($"Number {range} is not a PrimeNumber");
            }
        }

    }
}
