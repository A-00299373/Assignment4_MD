using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void TestSquareArea_Length5()
    {
        // Arrange
        var square = new Square(-5);

        // Act
        var area = square.CalculateArea();

        // Assert
        Assert.AreEqual(-25, area);
    }

    [TestMethod]
    public void TestSquareArea_Length10()
    {
        // Arrange
        var square = new Square(10);

        // Act
        var area = square.CalculateArea();

        // Assert
        Assert.AreEqual(100, area);
    }

    [TestMethod]
    public void TestSquareArea_Length0()
    {
        // Arrange
        var square = new Square(0);

        // Act
        var area = square.CalculateArea();

        // Assert
        Assert.AreEqual(0, area);
    }

    [TestMethod]
    public void TestSquarePerimeter_Length5()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var perimeter = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(20, perimeter);
    }

    [TestMethod]
    public void TestSquarePerimeter_Length10()
    {
        // Arrange
        var square = new Square(10);

        // Act
        var perimeter = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(40, perimeter);
    }

    [TestMethod]
    public void TestSquarePerimeter_Length0()
    {
        // Arrange
        var square = new Square(0);

        // Act
        var perimeter = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(0, perimeter);
    }
}
