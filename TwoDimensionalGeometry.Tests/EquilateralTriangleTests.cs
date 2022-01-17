// -----------------------------------------------------------------------------------------------
//  EquilateralTriangleTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class EquilateralTriangleTests
{
    private EquilateralTriangle _sut;

    public EquilateralTriangleTests()
    {
        _sut = new EquilateralTriangle(){Side = 1};
    }

    [Fact]
    public void GetArea_ValidValue_ShouldCalculateCorrectly()
    {
        var expected = 0.433;

        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual,3);
    }
    [Fact]
    public void GetArea_InvalidValue_ShouldReturnNegativeOne()
    {
        _sut.Side = -1;
        var expected = -1;

        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual,3);
    }

    [Fact]
    public void GetPerimeter_ValidValue_ShouldCalculateCorrectly()
    {
        var expected = 3f;

        var actual = _sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetPerimeter_InvalidValue_ShouldReturnNegativeOne()
    {
        _sut.Side = -1;
        var expected = -1;

        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual,3);
    }
}