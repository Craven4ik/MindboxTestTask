using FigureAreaLibrary.Figures;

namespace FigureAreaLibrary;

public static class AreaCalculator
{
    public static double CalcArea(IFigure shape)
        => shape.GetArea();
}
