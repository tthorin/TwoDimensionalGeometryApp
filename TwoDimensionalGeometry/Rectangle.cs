// -----------------------------------------------------------------------------------------------
//  Rectangle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;
using TwoDimensionalGeometry.Extensions;

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
    /// Initializes a new instance of the <see cref="Rectangle"/> class.
    /// </summary>
    /// <param name="height">The height of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    public Rectangle(float height = 0, float width = 0)
    {
        Height = height;
        Width = width;
    }

    /// <summary>
    /// Gets the area.
    /// </summary>
    /// <returns>The calculated area, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetArea() => Height <= 0 || Width <= 0 ? -1 : (Height * Width).MaxValueCheck();

    /// <summary>
    /// Gets the perimeter.
    /// </summary>
    /// <returns>The calculated perimeter, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetPerimeter() => Height <= 0 || Width <= 0 ? -1 : (Height * 2 + Width * 2).MaxValueCheck();
}