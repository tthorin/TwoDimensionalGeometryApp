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
}