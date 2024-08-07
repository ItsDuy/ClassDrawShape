namespace ClassDrawShape;

public class Circle
{
    private double radius;
    private string color;

    public Circle()
    {
        radius = 1.0;
        color = "red";
    }

    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    public double getRadius()
    {
        return radius;
    }

    public void setRadius(double radius)
    {
        this.radius = radius;
    }

    public string getColor()
    {
        return color;
    }

    public void setColor(string color)
    {
        this.color = color;
    }

    public double getArea()
    {
        return Math.PI * radius * radius;
    }

    public override string ToString()
    {
        return $"Circle[radius={radius}, color={color}, area={getArea()}]";
    }
}
public class Cylinder : Circle
{
    private double height;

    public Cylinder() : base()
    {
        height = 1.0;
    }

    public Cylinder(double radius, string color, double height) : base(radius, color)
    {
        this.height = height;
    }

    public double getHeight()
    {
        return height;
    }

    public void setHeight(double height)
    {
        this.height = height;
    }

    public double getVolume()
    {
        return getArea() * height;
    }

    public override string ToString()
    {
        return $"Cylinder[radius={getRadius()}, color={getColor()}, height={height}, volume={getVolume()}]";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5.0, "blue");
        Console.WriteLine(circle.ToString());

        Cylinder cylinder = new Cylinder(5.0, "green", 10.0);
        Console.WriteLine(cylinder.ToString());
    }
}
