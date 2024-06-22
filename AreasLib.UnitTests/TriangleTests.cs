namespace AreasLib.UnitTests;

public class TriangleTests
{
    [Fact]
    public void InitializeTest_ShouldCreateTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(3.0, triangle.SideA);
        Assert.Equal(4.0, triangle.SideB);
        Assert.Equal(5.0, triangle.SideC);
    }

    [Fact]
    public void InitializeWithNegativeTest_ShouldReturnException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-3.0, 4.0, 5.0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3.0, -4.0, 5.0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3.0, 4.0, -5.0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-3.0, -4.0, -5.0));
    }

    [Fact]
    public void InitializeWithInequlitySidesTheoremTest_ShouldReturnException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(3.0, 4.0, 10.0));
        Assert.Throws<ArgumentException>(() => new Triangle(10.0, 3.0, 4.0));
        Assert.Throws<ArgumentException>(() => new Triangle(10.0, 4.0, 3.0));
        Assert.Throws<ArgumentException>(() => new Triangle(4.0, 10.0, 3.0));
        Assert.Throws<ArgumentException>(() => new Triangle(4.0, 3.0, 10.0));
    }

    [Fact]
    public void AreaTest()
    {
        var triangle = new Triangle(3.0, 4.0, 5.0);
        var area = triangle.GetArea();
        Assert.Equal(6.0, area);
    }
}
