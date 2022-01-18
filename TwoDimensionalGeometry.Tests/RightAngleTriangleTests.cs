// -----------------------------------------------------------------------------------------------
//  RightAngleTriangleTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class RightAngleTriangleTests
{
    private readonly RightAngleTriangle _sut;

    public RightAngleTriangleTests()
    {
        _sut = new RightAngleTriangle {Height = 3, Width = 4};
    }
    
    [Fact]
    public void GetArea_ValidValues_ShouldCalculateCorrectly()
    {
        const float expected = 6; //height 3, width 4, 3*4 = 12 /2 = 6

        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void GetArea_TooHighResult_ShouldReturnZero()
    {
        const float expected = 0;
        _sut.Height = float.MaxValue;

        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    [Theory]
    [InlineData(3,-1,-1)]
    [InlineData(-1,4,-1)]
    public void GetArea_InvalidValues_ShouldReturnNegativeOne(float height,float width,float expected)
    {
        _sut.Height = height;
        _sut.Width = width;
        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void GetPerimeter_ValidValues_ShouldCalculateCorrectly()
    {
        const float expected = 12; //height 3, width 4 gives hyp 5, 3+4+5=12

        var actual = _sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void GetPerimeter_TooHighResult_ShouldReturnZero()
    {
        _sut.Height = float.MaxValue;
        const float expected = 0;

        var actual = _sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
    
    [Theory]
    [InlineData(3,-1,-1)]
    [InlineData(-1,4,-1)]
    public void GetPerimeter_InvalidValues_ShouldReturnNegativeOne(float height,float width,float expected)
    {
        _sut.Height = height;
        _sut.Width = width;
        var actual = _sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
}