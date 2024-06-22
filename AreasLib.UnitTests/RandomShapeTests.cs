namespace AreasLib.UnitTests;

public class RandomShapeTests
{
    [Fact]
    public void AreaTest()
    {
        for (int i = 0; i < 1000; i++)
        {
            IShape shape = new ShapeFactory().CreateRandomShape();
            var area = shape.GetArea();
            Assert.True(area > 0);
        }
    }
}
