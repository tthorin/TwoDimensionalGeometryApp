using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class SquareTests
{
    private readonly Square _sut;

    public SquareTests() => _sut = new Square {Side = 2};

    [Fact]
    public void GetArea_ValidSideValue_ShouldCalculateCorrectly()
    {
        const float expected = 4f;
        var actual = _sut.GetArea();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetArea_TooHighResult_ShouldReturnZero()
    {
        _sut.Side = float.MaxValue;
        const float expected = 0f;
        var actual = _sut.GetArea();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(-3f, -1)]
    [InlineData(0, -1)]
    public void GetArea_InValidSideValue_ShouldReturnNegativeOne(float side, float expected)
    {
        _sut.Side = side;

        var actual = _sut.GetArea();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetPerimeter_ValidSideValue_ShouldCalculateCorrectly()
    {
        const float expected = 8f;
        var actual = _sut.GetPerimeter();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetPerimeter_TooHighResult_ShouldReturnZero()
    {
        _sut.Side = float.MaxValue;
        const float expected = 0f;
        var actual = _sut.GetPerimeter();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetPerimeter_InvalidSideValue_ShouldReturnNegativeOne()
    {
        _sut.Side = -2;
        const float expected = -1f;
        var actual = _sut.GetPerimeter();

        Assert.Equal(expected, actual);
    }
}