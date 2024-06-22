namespace AreasLib.UnitTests;

public class RectangleTests
{
    [Fact]
    public void InitializeTest_ShouldCreateRectangleWithZeroValue()
    {
        Rectangle rectangle = new(-100, 10);
        Assert.Equal(0, rectangle.Length);
        Assert.Equal(10.0, rectangle.Width);

        rectangle = new(10, -100);
        Assert.Equal(10.0, rectangle.Length);
        Assert.Equal(0.0, rectangle.Width);

        rectangle = new(-100, -100);
        Assert.Equal(0.0, rectangle.Length);
        Assert.Equal(0.0, rectangle.Width);
    }

    [Fact]
    public void InitializeTest_ShouldCreateRectangle()
    {
        Rectangle rectangle = new(1, 2);
        Assert.Equal(1.0, rectangle.Length);
        Assert.Equal(2.0, rectangle.Width);
    }

    [Fact]
    public void AreaTest_ShouldReturnArea()
    {
        Rectangle rectangle = new(1, 2);
        Assert.Equal(2.0, rectangle.GetArea());
    }
}
