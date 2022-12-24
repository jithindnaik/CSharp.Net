
using System.Diagnostics;

class GradeApp
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the marks: ");
        int marks = Int32.Parse(Console.ReadLine());
        string displayGradeFormat = "Marks: {0}, Status: {1}, Grade: {2}";

        if (marks < 50)
        {
            Console.WriteLine(displayGradeFormat, marks, "Failed", "E Grade");
        }
        else
        {
            if (marks > 50 && marks < 55)
            {
                Console.WriteLine(displayGradeFormat, marks, "Passed", "D Grade");
            } else if (marks > 55 && marks < 65)
            {
                Console.WriteLine(displayGradeFormat, marks, "Passed", "C Grade");
            } else if (marks > 65 && marks < 75)
            {
                Console.WriteLine(displayGradeFormat, marks, "Passed", "B Grade");
            } else if (marks > 75 && marks < 90)
            {
                Console.WriteLine(displayGradeFormat, marks, "Passed", "A Grade");
            } else
            {
                Console.WriteLine(displayGradeFormat, marks, "Passed", "A+ Grade");
            }

        }
    }
}