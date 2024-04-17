namespace GeometryLibrary;

public class Triangle : IShape
{
    private double baseLength;
    private double height;
    private double sideA;
    private double sideB;

    public Triangle(double baseLength, double height, double sideA, double sideB)
    {
        this.baseLength = baseLength;
        this.height = height;
        this.sideA = sideA;
        this.sideB = sideB;
    }

    public double CalculateArea()
    {
        var result = 0.5 * baseLength * height;
        return result;
    }

    public double CalculatePerimeter()
    {
        var result = baseLength + sideA + sideB;
        return result;
    }
}
