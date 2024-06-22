namespace AreasLib;

public class ShapeFactory
{
    private Random _random;

    public ShapeFactory()
    {
        _random = new Random();
    }

    public IShape CreateRandomShape()
    {
        int shapeType = _random.Next(3);

        switch (shapeType)
        {
            case 0:
                return new Circle(_random.Next(1, 10));
            case 1:
                return new Rectangle(_random.Next(1, 10), _random.Next(1, 10));
            case 2:
                return new Triangle(_random.Next(3, 6), _random.Next(3, 5), _random.Next(4, 5));
            default:
                throw new InvalidOperationException("Invalid shape type generated");
        }
    }
}
