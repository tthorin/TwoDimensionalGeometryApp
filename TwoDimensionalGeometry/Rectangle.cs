// -----------------------------------------------------------------------------------------------
//  Rectangle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;
using static TwoDimensionalGeometry.Helpers.FloatHelper;

namespace TwoDimensionalGeometry;

/// <summary>
/// Object that stores or calculates the characteristics for a rectangle.
/// </summary>
/// <seealso cref="TwoDimensionalGeometry.Interfaces.ITwoDimensionalShape" />
public class Rectangle : ITwoDimensionalShape
{
    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    /// <value>
    /// The height.
    /// </value>
    public float Height { get; set; }

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    /// <value>
    /// The width.
    /// </value>
    public float Width { get; set; }

    /// <summary>
    /// Gets the area.
    /// </summary>
    /// <returns>The calculated area, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetArea() => Height <= 0 || Width <= 0 ? -1 : MaxValueCheck(Height * Width);

    /// <summary>
    /// Gets the perimeter.
    /// </summary>
    /// <returns>The calculated perimeter, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetPerimeter() => Height <= 0 || Width <= 0 ? -1 : MaxValueCheck(Height * 2 + Width * 2);
}