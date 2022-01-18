// -----------------------------------------------------------------------------------------------
//  GeometricCalculator.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

public static class GeometricCalculator
{
    public static float GetArea(ITwoDimensionalShape shape) => shape != null ? shape.GetArea() : -2;

    public static float GetPerimeter(ITwoDimensionalShape shape) => shape != null ? shape.GetPerimeter() : -2;

    public static float GetPerimeter(ICollection<ITwoDimensionalShape> shapes)
    {
        if (shapes.Count == 0 || shapes.Contains(null) || shapes == null) return -2;
        var output = 0f;
        foreach (var shape in shapes)
        {
            var result = shape.GetPerimeter();
            if (result <= 0) return result <= -1 ? -1 : 0;

            output += shape.GetPerimeter();
        }

        return output;
    }
}