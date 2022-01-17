// -----------------------------------------------------------------------------------------------
//  GeometricCalculatorTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System.Collections.Generic;
using TwoDimensionalGeometry.Interfaces;
using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class GeometricCalculatorTests
{
    private Square _square;
    private ITwoDimensionalShape[] _shapes;

    public GeometricCalculatorTests()
    {
        _square = new Square() {Side = 2};
        _shapes = new ITwoDimensionalShape[]
        {
            new Square(){Side = 2}, //perim = 8
            new Rectangle(){Height = 1,Width = 2}, //perim = 6
            new RightAngleTriangle(){Height = 3,Width = 4} //perim = 12
        };
    }
    [Fact]
    public void GetArea_ValidShape_ShouldReturnAreaCorrectly()
    {
        const float expected = 4f;

        var actual = GeometricCalculator.GetArea(_square);
        
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void GetPerimeter_ValidShape_ShouldReturnAreaCorrectly()
    {
        const float expected = 8f;

        var actual = GeometricCalculator.GetPerimeter(_square);
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetPerimeter_ValidShapes_ShouldReturnAreaCorrectly()
    {
        const float expected = 26f;

        var actual = GeometricCalculator.GetPerimeter(_shapes);
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetPerimeter_OneOrMoreInvalidShapeS_ShouldReturnNegativeOne()
    {
        var badshapes = new ITwoDimensionalShape[] {new Square() {Side = -1}}; 
        const float expected = -1f;

        var actual = GeometricCalculator.GetPerimeter(badshapes);
        
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void GetPerimeter_EmptyCollection_ShouldReturnNegativeOne()
    {
        var badshapes = new List<ITwoDimensionalShape>(); 
        const float expected = -1f;

        var actual = GeometricCalculator.GetPerimeter(badshapes);
        
        Assert.Equal(expected,actual);
    }
}