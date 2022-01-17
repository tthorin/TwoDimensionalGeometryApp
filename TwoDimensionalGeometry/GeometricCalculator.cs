// -----------------------------------------------------------------------------------------------
//  GeometricCalculator.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

public static class GeometricCalculator
{
    public static float GetArea(ITwoDimensionalShape shape) => shape.GetArea();

    public static float GetPerimeter(ITwoDimensionalShape shape) => shape.GetPerimeter();

    public static float GetPerimeter(ICollection<ITwoDimensionalShape> shapes)
    {
        if (shapes.Count == 0) return -1;
        var output = 0f;
        foreach (var shape in shapes)
        {
            if (shape.GetPerimeter() == -1) return -1;
            output += shape.GetPerimeter();
        }
        
        return output;
    }
}