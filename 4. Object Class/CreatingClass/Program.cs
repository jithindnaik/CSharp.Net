using System.Xml.Linq;

class Employee
{
    int id;
    string name;
    double salary; 

    public static void Main(string[] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();

        e1.SetEmployeeSalary(1, "Employee1", 5500.245);
        e2.SetEmployeeSalary(2, "Employee2", 20000.245);

        e1.PrintEmployeeDetails();
        e2.PrintEmployeeDetails();
    }

    public void SetEmployeeSalary(int id, string name, double salary)
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    public void PrintEmployeeDetails()
    {
        Console.WriteLine($"Employee ID: {id} ");
        Console.WriteLine($"Employee Name: {name} ");
        Console.WriteLine($"Employee Salary: {salary} ");
        Console.WriteLine();
    }
}