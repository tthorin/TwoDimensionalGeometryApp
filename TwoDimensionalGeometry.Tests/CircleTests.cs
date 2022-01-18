// -----------------------------------------------------------------------------------------------
//  CircleTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class CircleTests
{
    private readonly Circle _sut;

    public CircleTests()
    {
        _sut = new Circle(1);
    }

    [Fact]
    public void GetArea_ValidRadius_ShouldCalculateCorrectly()
    {
        const float expected = 3.14f; //pi * radius^2 = 3,14 * 1^2 = 3,14 * 1 = 3,14

        var actual = _sut.GetArea();

        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void GetArea_InvalidRadius_ShouldReturnNegativeOne()
    {
        _sut.Radius = -5;
        const float expected = -1;

        var actual = _sut.GetArea();

        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void GetArea_TooHighResult_ShouldReturnZero()
    {
        _sut.Radius = float.MaxValue;
        const float expected = 0;

        var actual = _sut.GetArea();

        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void GetPerimeter_ValidRadius_ShouldCalculateCorrectly()
    {
        const float expected = 6.28f; //2*pi*radius = 2 * 3,14 * 1 = 2 * 3,14 = 6,28

        var actual = _sut.GetPerimeter();

        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void GetPerimeter_InvalidRadius_ShouldReturnNegativeOne()
    {
        _sut.Radius = 0;
        const float expected = -1;

        var actual = _sut.GetPerimeter();

        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void GetPerimeter_TooHighResult_ShouldReturnZero()
    {
        _sut.Radius = float.MaxValue;
        const float expected = 0;

        var actual = _sut.GetPerimeter();

        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void Diameter_SettingValue_ShouldSetRadiusToExpectedValue()
    {
        _sut.Diameter = 2;
        const float expected = 1;

        var actual = _sut.Radius;

        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void Diameter_GettingValue_ShouldReturnExpectedValue()
    {
        var expected = _sut.Radius * 2;

        var actual = _sut.Diameter;

        Assert.Equal(expected, actual, 2);
    }
}