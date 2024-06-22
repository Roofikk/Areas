namespace AreasLib;

public class Circle : IShape
{
    private double _radius;

    public double Radius
    {
        get
        {
            return _radius;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Radius cannot be negative");
            }

            _radius = value;
        }
    }

    public Circle(double radius)
    {
        try
        {
            Radius = radius;
        }
        catch (ArgumentException ex)
        {
            throw new ArgumentException(ex.Message, nameof(radius));
        }
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
