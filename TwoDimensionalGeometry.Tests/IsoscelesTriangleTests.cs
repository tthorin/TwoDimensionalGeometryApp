// -----------------------------------------------------------------------------------------------
//  IsoscelesTriangleTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class IsoscelesTriangleTests
{
    private readonly IsoscelesTriangle _sut;

    public IsoscelesTriangleTests()
    {
        _sut = new IsoscelesTriangle {Base = 6,Legs = 5};
    }

    [Fact]
    public void GetArea_ValidValues_ShouldCalculateCorrectly()
    {
        const float expected = 12f; //https://en.wikipedia.org/wiki/Isosceles_triangle#Area

        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetArea_TooHighResult_ShouldReturnZero()
    {
        _sut.Legs = float.MaxValue;
        const float expected = 0;

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
        const float expected = -1f;

        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetPerimeter_ValidValues_ShouldCalculateCorrectly()
    {
        const float expected = 16f; //triangle base + legs * 2

        var actual = _sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetPerimeter_TooHighResult_ShouldReturnZero()
    {
        _sut.Legs = float.MaxValue;
        const float expected = 0f;

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
        const float expected = -1f;

        var actual = _sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
}