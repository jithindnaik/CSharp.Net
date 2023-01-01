using System;

class PrimeNumber
{

    public int GetRangeUntil()
    {
        Console.WriteLine("Enter the range of number to display for prime starting from 0");
        return Int32.Parse(s: Console.ReadLine());
    }

    public int GetUserInputNumber()
    {
        Console.WriteLine("Enter the number to be checked for Prime");
        return Int32.Parse(s: Console.ReadLine());
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
            if (number == 2 || number == 3 || number == 5)
            {
                isPrime = true;
            }
            else
            {
                if ((number % 2) == 0 || (number % 3) == 0 || (number % 5) == 0)
                {
                    isPrime = false;
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
        //}
        //else
        //{
        //    Console.WriteLine($"Number {numberEntered} is not a PrimeNumber");
        //}

        PrimeNumber p = new PrimeNumber();
        int numberRange = p.GetRangeUntil();

        for (var range = 0; range <= numberRange; range++)
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
