namespace FigureAreaLibrary.Figures;

public class Triangle : IFigure
{
    private double _sideA {  get; set; }
    private double _sideB {  get; set; }
    private double _sideC {  get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public bool IsExistTriangle()
    {
        if ((_sideA + _sideB) > _sideC && (_sideA + _sideC) > _sideB && (_sideB + _sideC) > _sideA)
            return true;

        return false;
    }

    public bool IsRectangular()
    {
        List<double> sides = new List<double>() { _sideA, _sideB, _sideC };
        sides.Sort();

        return Math.Pow(sides[2], 2) == (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
    }

    public double GetArea()
    {
        double halfMeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(halfMeter * (halfMeter - _sideA) * (halfMeter - _sideB) * (halfMeter - _sideC));
    }
}
