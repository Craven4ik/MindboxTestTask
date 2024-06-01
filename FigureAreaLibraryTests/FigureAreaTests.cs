using FigureAreaLibrary.Figures;

namespace FigureAreaLibrary;

public class FigureAreaTests
{
    [Theory]
    [InlineData(3, 28.274334)]
    [InlineData(5.5, 95.033178)]
    public void CircleAreaTest(double radius, double expectedArea)
    {
        Circle circle = new Circle(radius);
        double area = AreaCalculator.CalcArea(circle);

        Assert.Equal(expectedArea, area, 5);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(4, 10, 12, 18.734993)]
    public void TriangleAreaTest(double sideA, double sideB, double sideC, double expectedArea)
    {
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        double area = AreaCalculator.CalcArea(triangle);

        Assert.Equal(expectedArea, area, 5);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(4, 10, 12, true)]
    [InlineData(4, 10, 100, false)]
    public void IsExistTriangleTest(double sideA, double sideB, double sideC, bool expectedResult)
    {
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        bool result = triangle.IsExistTriangle();

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(5, 12, 13, true)]
    [InlineData(4, 10, 12, false)]
    public void IsRectangleTest(double sideA, double sideB, double sideC, bool expectedResult)
    {
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        bool result = triangle.IsRectangular();

        Assert.Equal(expectedResult, result);
    }
}
