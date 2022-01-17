using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class SquareTests
{
    private Square sut;
    public SquareTests()
    {
        sut = new Square() {Side = 2};
    }
    [Fact]
    public void GetArea_ValidSideValue_ShouldCalculateCorrectly()
    {
        var expected = 4f;
        var actual = sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    [Theory]
    [InlineData(-3f,-1)]
    [InlineData(0,-1)]
    public void GetArea_InValidSideValue_ShouldReturnNegativeOne(float side,float expected)
    {
        sut.Side = side;
        
        var actual = sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void GetPerimeter_ValidSideValue_ShouldCalculateCorrectly()
    {
        var expected = 8f;
        var actual = sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void GetPerimeter_InvalidSideValue_ShouldReturnNegativeOne()
    {
        sut.Side = -2;
        var expected = -1;
        var actual = sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
}