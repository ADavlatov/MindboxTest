using MindboxTest.Interfaces;

namespace MindboxTest.Shapes;

public class Triangle : IShape
{
    private readonly double[] _sides;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA < 0 || sideB < 0 || sideC < 0)
        {
            throw new ArgumentException("Side lenght can't be negative");
        }

        _sides = [sideA, sideB, sideC];
        Array.Sort(_sides);

        if (_sides[0] + _sides[1] <= _sides[2])
        {
            throw new ArgumentException("This is not triangle");
        }
    }

    public double CalculateArea()
    {
        if (IsTriangleRight())
        {
            return 0.5 * (_sides[0] * _sides[1]);
        }

        var halfMeter = (_sides[0] + _sides[1] + _sides[2]) / 2;

        return Math.Sqrt(halfMeter * (halfMeter - _sides[0]) *
                         (halfMeter - _sides[1]) *
                         (halfMeter - _sides[2]));
    }

    public bool IsTriangleRight()
    {
        return Math.Abs(Math.Abs(Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2)) - Math.Pow(_sides[2], 2)) < 1e-10;
    }
}