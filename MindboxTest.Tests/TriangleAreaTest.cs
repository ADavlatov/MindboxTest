using MindboxTest.Shapes;

namespace MindboxTest.Tests;

public class TriangleAreaTest
{
    [Fact]
    public void TestCircleArea()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.CalculateArea(), 1e-10);
    }
    
    [Fact]
    public void TestTriangleIsReght()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsTriangleRight());
        
        var nonRightTriangle = new Triangle(2, 2, 3);
        Assert.False(nonRightTriangle.IsTriangleRight());
    }
}