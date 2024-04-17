using GeometryLibrary;

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void Square_Method_Receives_Length_5_And_Returns_25_For_The_Area_Of_Square()
    {
        var square = new Square(5);

        var ret = square.CalculateArea();

        Assert.AreEqual(25, ret);
    }

    [TestMethod]
    public void Square_Method_Receives_Length_10_And_Returns_100_For_The_Area_Of_Square()
    {
        var square = new Square(10);

        var ret = square.CalculateArea();

        Assert.AreEqual(100, ret);
    }

    [TestMethod]
    public void Square_Method_Receives_Length_0_And_Returns_0_For_The_Area_Of_Square()
    {
        var square = new Square(0);

        var ret = square.CalculateArea();

        Assert.AreEqual(0, ret);
    }

    [TestMethod]
    public void Square_Method_Receives_Length_7_And_Returns_28_For_The_Perimeter_Of_Square()
    {
        var square = new Square(7);

        var ret = square.CalculatePerimeter();

        Assert.AreEqual(28, ret);
    }

    [TestMethod]
    public void Square_Method_Receives_Length_12_And_Returns_48_For_The_Perimeter_Of_Square()
    {
        var square = new Square(12);

        var ret = square.CalculatePerimeter();

        Assert.AreEqual(48, ret);
    }

    [TestMethod]
    public void Square_Method_Receives_Length_0_And_Returns_0_For_The_Perimeter_Of_Square()
    {
        var square = new Square(0);

        var ret = square.CalculatePerimeter();

        Assert.AreEqual(0, ret);
    }
}
