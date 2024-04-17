using GeometryLibrary;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Triangle_Method_Receives_baseLength_3_And_height_7_Returns_11_5_For_The_Area_Of_Triangle()
    {
        var triangle = new Triangle(3, 7, 0, 0);

        var ret = triangle.CalculateArea();

        Assert.AreEqual(10.5, ret);
    }

    [TestMethod]
    public void Triangle_Method_Receives_baseLength_8_And_height_2_Returns_8_For_The_Area_Of_Triangle()
    {
        var triangle = new Triangle(8, 2, 0, 0);

        var ret = triangle.CalculateArea();

        Assert.AreEqual(8, ret);
    }

    [TestMethod]
    public void Triangle_Method_Receives_baseLength_0_And_height_6_Returns_0_For_The_Area_Of_Triangle()
    {
        var triangle = new Triangle(0, 6, 0, 0);

        var ret = triangle.CalculateArea();

        Assert.AreEqual(0, ret);
    }

    [TestMethod]
    public void Triangle_Method_Receives_baseLength_4_And_SideA_6_And_SideB_7_Returns_17_For_The_Perimeter_Of_Triangle()
    {
        var triangle = new Triangle(4, 0, 6, 7);

        var ret = triangle.CalculatePerimeter();

        Assert.AreEqual(17, ret);
    }

    [TestMethod]
    public void Triangle_Method_Receives_baseLength_2_And_SideA_10_And_SideB_8_Returns_20_For_The_Perimeter_Of_Triangle()
    {
        var triangle = new Triangle(2, 0, 10, 8);

        var ret = triangle.CalculatePerimeter();

        Assert.AreEqual(20, ret);
    }

    [TestMethod]
    public void Triangle_Method_Receives_baseLength_0_And_SideA_0_And_SideB_0_Returns_0_For_The_Perimeter_Of_Triangle()
    {
        var triangle = new Triangle(0, 0, 0, 0);

        var ret = triangle.CalculatePerimeter();

        Assert.AreEqual(0, ret);
    }
}