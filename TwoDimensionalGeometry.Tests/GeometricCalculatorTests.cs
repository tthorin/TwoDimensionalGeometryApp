// -----------------------------------------------------------------------------------------------
//  GeometricCalculatorTests.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using TwoDimensionalGeometry.Interfaces;
using Xunit;

namespace TwoDimensionalGeometry.Tests;

public class GeometricCalculatorTests
{
    private readonly Square _square;
    private readonly ITwoDimensionalShape[] _shapes;

    public GeometricCalculatorTests()
    {
        _square = new Square {Side = 2};
        _shapes = new ITwoDimensionalShape[]
        {
            new Square {Side = 2}, //perimeter = 8
            new Rectangle {Height = 1,Width = 2}, //perimeter = 6
            new RightAngleTriangle {Height = 3,Width = 4} //perimeter = 12
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
    public void GetArea_NullReference_ShouldReturnNegativeTwo()
    {
        Square nullSquare = null;
        const float expected = -2;

        var actual = GeometricCalculator.GetArea(nullSquare);
        
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
    public void GetPerimeter_NullReference_ShouldReturnNegativeTwo()
    {
        Square nullSquare = null;
        const float expected = -2;

        var actual = GeometricCalculator.GetPerimeter(nullSquare);
        
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
    public void GetPerimeter_OneOrMoreShapeWithTooHighResult_ShouldReturnZero()
    {
        var badShapes = new ITwoDimensionalShape[] {new Square {Side = float.MaxValue},new Circle{Radius = 1}};
        const float expected =0f;

        var actual = GeometricCalculator.GetPerimeter(badShapes);
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetPerimeter_OneOrMoreInvalidShapes_ShouldReturnNegativeOne()
    {
        var badShapes = new ITwoDimensionalShape[] {new Square {Side = -1},new Circle{Radius = 1}};
        const float expected = -1f;

        var actual = GeometricCalculator.GetPerimeter(badShapes);
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetPerimeter_OneOrMoreNullReferenceInCollection_ShouldReturnNegativeTwo()
    {
        Array.Clear(_shapes);
        const float expected = -2f;

        var actual = GeometricCalculator.GetPerimeter(_shapes);
        
        Assert.Equal(expected,actual);
    }
    
    [Fact]
    public void GetPerimeter_EmptyCollection_ShouldReturnNegativeTwo()
    {
        var badShapes = new List<ITwoDimensionalShape>(); 
        const float expected = -2f;

        var actual = GeometricCalculator.GetPerimeter(badShapes);
        
        Assert.Equal(expected,actual);
    }
}