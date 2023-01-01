class Shape
{
    public int len = 30;
    public int breadth = 20;
    public int area;

    public virtual int Area()
    {
        return 0;
    }

    public Shape()
    {
        //this.len = 30;
        //this.breadth = 20;
        Console.WriteLine("Shape constructor is invoked");
    }
}

class Rectangle: Shape
{
    public int len = 50;

    public override int Area()
    {
        return this.len * this.breadth;
    }

    public Rectangle()
    {
        Console.WriteLine("Rectangle constructor is invoked");
    }
}

class Square: Shape
{
    public override int Area()
    {
        return this.len * this.len;
    }

    public Square()
    {
        Console.WriteLine("Square constructor is invoked");
    }
}

public class Program
{
    public static void Main()
    {
        Shape s;
        s = new Rectangle();
        Console.WriteLine(s.Area());
        s = new Square();
        Console.WriteLine(s.Area());

        Shape s1 = new Rectangle();
        Console.WriteLine(s1.len);
    }
}