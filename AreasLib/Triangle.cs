namespace AreasLib;

public class Triangle : IShape
{
    private double _a;
    private double _b;
    private double _c;

    public double SideA
    {
        get
        {
            return _a;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(SideA), "A cannot be negative");
            }

            if (value >= _b + _c)
            {
                throw new ArgumentException(nameof(SideA), "A cannot be less than the sum of B and C");
            }

            _a = value;
        }
    }
    public double SideB
    {
        get
        {
            return _b;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(SideB), "B cannot be negative");
            }

            if (value >= _a + _c)
            {
                throw new ArgumentException(nameof(SideB), "B cannot be less than the sum of A and C");
            }

            _b = value;
        }
    }
    public double SideC
    {
        get
        {
            return _c;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(SideC), "C cannot be negative");
            }

            if (value >= _a + _b)
            {
                throw new ArgumentException(nameof(SideC), "C cannot be less than the sum of A and B");
            }

            _c = value;
        }
    }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentOutOfRangeException("All sides of the triangle must be greater than zero");
        }

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ArgumentException("The sum of any two sides must be greater than the third side");
        }

        _a = a;
        _b = b;
        _c = c;
    }

    // формула Герона
    public double GetArea()
    {
        double p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public bool IsRightAngledTriangle()
    {
        double[] sides = new double[] { SideA, SideB, SideC };
        Array.Sort(sides);

        return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
    }
}
