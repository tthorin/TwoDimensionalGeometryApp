// -----------------------------------------------------------------------------------------------
//  RectangleTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;
using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class RectangleTests
{
    private Rectangle sut;
    public RectangleTests()
    {
        sut = new Rectangle() {Height = 2,Width = 3};
    }
    [Fact]
    public void GetArea_ValidSideValue_ShouldCalculateCorrectly()
    {
        var expected = 6f;
        var actual = sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    [Theory]
    [InlineData(-1f,1f,-1)]
    [InlineData(1,-1f,-1)]
    public void GetArea_InvalidValue_ShouldReturnNegativeOne(float height,float width,float expected)
    {
        sut.Height = height;
        sut.Width = width;
        
        var actual = sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void GetPerimeter_ValidValues_ShouldCalculateCorrectly()
    {
        var expected = 10f;
        var actual = sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
    [Theory]
    [InlineData(-1f,1f,-1)]
    [InlineData(1,-1f,-1)]
    public void GetPerimeter_InvalidValues_ShouldReturnNegativeOne(float height,float width,float expected)
    {
        sut.Height = height;
        sut.Width = width;
        
        var actual = sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
}