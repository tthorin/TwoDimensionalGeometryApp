// -----------------------------------------------------------------------------------------------
//  IsoscelesTriangleTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class IsoscelesTriangleTests
{
    private IsoscelesTriangle _sut;

    public IsoscelesTriangleTests()
    {
        _sut = new(){Base = 6,Legs = 5};
    }

    [Fact]
    public void GetArea_ValidValues_ShouldCalculateCorrectly()
    {
        const float expected = 12f;

        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    
    [Theory]
    [InlineData(1f,-1f)]
    [InlineData(-1f,1f)]
    [InlineData(2f,1f)]
    public void GetArea_InvalidValues_ShouldReturnNegativeOne(float triangleBase,float legs)
    {
        _sut.Base = triangleBase;
        _sut.Legs = legs;
        var expected = -1f;

        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetPerimeter_ValidValues_ShouldCalculateCorrectly()
    {
        const float expected = 16f;

        var actual = _sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
    [Theory]
    [InlineData(1f,-1f)]
    [InlineData(-1f,1f)]
    [InlineData(2f,1f)]
    public void GetPerimeter_InvalidValues_ShouldReturnNegativeOne(float triangleBase,float legs)
    {
        _sut.Base = triangleBase;
        _sut.Legs = legs;
        var expected = -1f;

        var actual = _sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
}