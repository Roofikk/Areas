namespace AreasLib.UnitTests;

public class CircleTests
{
    [Fact]
    public void InitializeTest_ShouldCreateCircle()
    {
        Circle circle = new(1);
        Assert.Equal(1, circle.Radius);
    }

    [Fact]
    public void InitializeTest_ShouldReturnException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-2));
    }

    [Fact]
    public void AreaTest_ShouldReturnArea()
    {
        Circle circle = new(1);
        Assert.Equal(Math.PI, circle.GetArea());
    }
}