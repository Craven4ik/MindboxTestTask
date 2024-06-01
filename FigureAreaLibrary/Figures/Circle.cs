namespace FigureAreaLibrary.Figures;

public class Circle : IFigure
{
    private double _radius {  get; init; }

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
        => Math.PI * Math.Pow(_radius, 2);
}
