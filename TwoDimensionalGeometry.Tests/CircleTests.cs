// -----------------------------------------------------------------------------------------------
//  CircleTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;
using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class CircleTests
{
    private readonly Circle _sut;

    public CircleTests()
    {
        _sut = new Circle() {Radius = 1};
    }

    [Fact]
    public void GetArea_ValidRadius_ShouldCalculateCorrectly()
    {
        const double expected = 3.14; //pi * radius^2 = 3,14 * 1^2 = 3,14 * 1 = 3,14

        var actual = _sut.GetArea();

        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void GetArea_InvalidRadius_ShouldReturnNegativeOne()
    {
        _sut.Radius = -5;
        const int expected = -1;

        var actual = _sut.GetArea();

        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void GetPerimeter_ValidRadius_ShouldCalculateCorrectly()
    {
        const double expected = 6.28; //2*pi*radius = 2 * 3,14 * 1 = 2 * 3,14 = 6,28

        var actual = _sut.GetPerimeter();

        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void GetPerimeter_InvalidRadius_ShouldReturnNegativeOne()
    {
        _sut.Radius = -1;
        const int expected = -1;

        var actual = _sut.GetPerimeter();

        Assert.Equal(expected, actual, 2);
    }
}