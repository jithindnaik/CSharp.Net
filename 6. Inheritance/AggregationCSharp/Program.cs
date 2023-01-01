class Address {
    public string city;
    public string state;
    public string addressName = "";

   public Address(string city, string state, string addressName)
    {
        this.city = city;
        this.state = state;
        this.addressName = addressName;
    }
}

class Employee
{
    string empName;
    Address address; // Has-a-relationship

    public Employee(string empName, Address address)
    {
        this.empName = empName;
        this.address = address;
    }

    public void printEmployee()
    {
        Console.WriteLine($"Emp Name: {this.empName}");
        Console.WriteLine($"Emp Address: City: {this.address.city}, State: {this.address.state}, AddressName: {this.address.addressName}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Address a = new Address("Kochi", "Kerala", "FortKochi Beach");

        Employee e = new Employee("Ramu", a);
        e.printEmployee();
    }
}
