using System.Formats.Asn1;

public class Circle : Shape
{
    private double _radius;

public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return 3.1415 * _radius * _radius;
    }
}