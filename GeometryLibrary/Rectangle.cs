using GeometryLibrary;

namespace GeometryLibrary;

public class Rectangle : IShape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double CalculateArea()
    {
        var result = length * width;
        return result;
    }

    public double CalculatePerimeter()
    {
        var result = 2 * (length + width);
        return result;
    }
}
