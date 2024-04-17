namespace GeometryLibrary;
public class Square : IShape
{
    private double Length;

    public Square(double Length)
    {
        this.Length = Length;
    }

    public double CalculateArea()
    {
        var result = Length * Length;
        return result;
    }

    public double CalculatePerimeter()
    {
        var result = 4 * Length;
        return result;
    }
}
