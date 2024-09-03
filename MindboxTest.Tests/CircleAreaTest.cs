using MindboxTest.Shapes;

namespace MindboxTest.Tests;

public class CircleAreaTest
{
    [Fact]
    public void TestCircleArea()
    {
        var circle = new Circle(5);
        Assert.Equal(Math.PI * 25, circle.CalculateArea(), 1e-10);
    }
}