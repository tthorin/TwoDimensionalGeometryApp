// -----------------------------------------------------------------------------------------------
//  RectangleTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class RectangleTests
{
    private readonly Rectangle _sut;
    
    public RectangleTests() => _sut = new Rectangle {Height = 2,Width = 3};

    [Fact]
    public void GetArea_ValidSideValue_ShouldCalculateCorrectly()
    {
        const float expected = 6f;
        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetArea_TooHighResult_ShouldReturnZero()
    {
        _sut.Height = float.MaxValue;
        const float expected = 0f;
        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    
    [Theory]
    [InlineData(0f,1f,-1)]
    [InlineData(1,-1f,-1)]
    public void GetArea_InvalidValue_ShouldReturnNegativeOne(float height,float width,float expected)
    {
        _sut.Height = height;
        _sut.Width = width;
        
        var actual = _sut.GetArea();
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetPerimeter_ValidValues_ShouldCalculateCorrectly()
    {
        const float expected = 10f;
        var actual = _sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetPerimeter_TooHighResult_ShouldReturnZero()
    {
        _sut.Height = float.MaxValue;
        const float expected = 0f;
        var actual = _sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
    
    [Theory]
    [InlineData(0f,1f,-1)]
    [InlineData(1,-1f,-1)]
    public void GetPerimeter_InvalidValues_ShouldReturnNegativeOne(float height,float width,float expected)
    {
        _sut.Height = height;
        _sut.Width = width;
        
        var actual = _sut.GetPerimeter();
        
        Assert.Equal(expected,actual);
    }
}