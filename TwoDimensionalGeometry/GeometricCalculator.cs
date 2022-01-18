// -----------------------------------------------------------------------------------------------
//  GeometricCalculator.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

/// <summary>
/// Class for passing in a single or multiple two dimensional shapes and getting (sum of) area or (sum of) perimeter back.
/// </summary>
public static class GeometricCalculator
{
    /// <summary>
    /// Gets the area of the passed in shape.
    /// </summary>
    /// <param name="shape">The two dimensional shape to get the area of.</param>
    /// <returns>The calculated area, or 0 if result of calculation is too high, -1 if a dimension is negative or -2 if the shape is null.</returns>
    public static float GetArea(ITwoDimensionalShape shape) => shape != null ? shape.GetArea() : -2;

    /// <summary>
    /// Gets the sum of the areas of the passed in collection of shapes.
    /// </summary>
    /// <param name="shapes">Collection of two dimensional shapes to get the areas of.</param>
    /// <returns>The sum of the calculated areas, or 0 if result of calculation is too high, -1 if a dimension is negative or -2 if the collection or a shape is null.</returns>
    public static float GetArea(ICollection<ITwoDimensionalShape> shapes)
    {
        if (shapes.Count == 0 || shapes.Contains(null) || shapes == null) return -2;
        var output = 0f;
        foreach (var shape in shapes)
        {
            var result = shape.GetArea();
            if (result <= 0) return result <= -1 ? -1 : 0;

            output += result;
        }

        return output;
    }

    /// <summary>
    /// Gets the perimeter of the passed in shape.
    /// </summary>
    /// <param name="shape">The two dimensional shape to get the area of.</param>
    /// <returns>The calculated perimeter, or 0 if result of calculation is too high, -1 if a dimension is negative or -2 if the shape is null.</returns>
    public static float GetPerimeter(ITwoDimensionalShape shape) => shape != null ? shape.GetPerimeter() : -2;

    /// <summary>
    /// Gets the sum of the perimeters of the passed in collection of shapes.
    /// </summary>
    /// <param name="shapes">Collection of two dimensional shapes to get the perimeters of.</param>
    /// <returns>The sum of the calculated perimeters, or 0 if result of calculation is too high, -1 if a dimension is negative or -2 if the collection or a shape is null.</returns>
    public static float GetPerimeter(ICollection<ITwoDimensionalShape> shapes)
    {
        if (shapes.Count == 0 || shapes.Contains(null) || shapes == null) return -2;
        var output = 0f;
        foreach (var shape in shapes)
        {
            var result = shape.GetPerimeter();
            if (result <= 0) return result <= -1 ? -1 : 0;

            output += result;
        }

        return output;
    }
}