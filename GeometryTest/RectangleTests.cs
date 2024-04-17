using GeometryLibrary;

[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void Rectangle_Method_Receives_Length_5_And_Width_7_Returns_35_For_The_Area_Of_Rectangle()
    {
        var rectangle = new Rectangle(5, 7);

        var ret = rectangle.CalculateArea();

        Assert.AreEqual(35, ret);
    }

    [TestMethod]
    public void Rectangle_Method_Receives_Length_7_And_Width_8_Returns_56_For_The_Area_Of_Rectangle()
    {
        var rectangle = new Rectangle(7, 8);

        var ret = rectangle.CalculateArea();

        Assert.AreEqual(56, ret);
    }

    [TestMethod]
    public void Rectangle_Method_Receives_Length_0_And_Width_8_Returns_0_For_The_Area_Of_Rectangle()
    {
        var rectangle = new Rectangle(0, 8);

        var ret = rectangle.CalculateArea();

        Assert.AreEqual(0, ret);
    }

    [TestMethod]
    public void Rectangle_Method_Receives_Length_7_And_Width_2_Returns_18_For_The_Perimeter_Of_Rectangle()
    {
        var rectangle = new Rectangle(7, 2);

        var ret = rectangle.CalculatePerimeter();

        Assert.AreEqual(18, ret);
    }

    [TestMethod]
    public void Rectangle_Method_Receives_Length_1_And_Width_1_Returns_4_For_The_Perimeter_Of_Rectangle()
    {
        var rectangle = new Rectangle(1, 1);

        var ret = rectangle.CalculatePerimeter();

        Assert.AreEqual(4, ret);
    }

    [TestMethod]
    public void Rectangle_Method_Receives_Length_0_And_Width_0_Returns_0_For_The_Perimeter_Of_Rectangle()
    {
        var rectangle = new Rectangle(0, 0);

        var ret = rectangle.CalculatePerimeter();

        Assert.AreEqual(0, ret);
    }
}