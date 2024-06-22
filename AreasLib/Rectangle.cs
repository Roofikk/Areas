namespace AreasLib;

/// <summary>
/// Дополнительная фигура для добавления функциональности вычисления ее площади
/// </summary>
public class Rectangle : IShape
{
    private double _width;
    private double _length;

    // Изменил условие ошибочной установки значения.
    // В таком случае лучше уточнить этот нюанс у заказчика, как необходимо обработать ошибочынй ввод
    public double Width { get => _width; set => _width = value < 0 ? 0 : value; }
    public double Length { get => _length; set => _length = value < 0 ? 0 : value; }

    public Rectangle(double height, double width)
    {
        Length = height;
        Width = width;
    }

    public double GetArea()
    {
        return Width * Length;
    }
}
