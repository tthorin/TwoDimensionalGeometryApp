// -----------------------------------------------------------------------------------------------
//  TriangleRightAngle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Extensions;
using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

/// <summary>
///     Object that stores or calculates the characteristics for a right angle triangle.
/// </summary>
/// <seealso cref="TwoDimensionalGeometry.Interfaces.ITwoDimensionalShape" />
public class RightAngleTriangle : ITwoDimensionalShape
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RightAngleTriangle" /> class.
    /// </summary>
    /// <param name="height">The height of the triangle.</param>
    /// <param name="width">The width of the triangle.</param>
    public RightAngleTriangle(float height = 0, float width = 0)
    {
        Height = height;
        Width = width;
    }

    /// <summary>
    ///     Gets or sets the height of thee triangle.
    /// </summary>
    /// <value>
    ///     The height.
    /// </value>
    public float Height { get; set; }

    /// <summary>
    ///     Gets or sets the width of the triangle.
    /// </summary>
    /// <value>
    ///     The width.
    /// </value>
    public float Width { get; set; }

    /// <summary>
    ///     Gets the area.
    /// </summary>
    /// <returns>The calculated area, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetArea() => Height > 0 && Width > 0 ? (Height * Width / 2).MaxValueCheck() : -1;

    /// <summary>
    ///     Gets the perimeter.
    /// </summary>
    /// <returns>The calculated perimeter, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetPerimeter()
    {
        if (Height <= 0 || Width <= 0) return -1;

        var hypotenuse = (float) Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
        return (hypotenuse + Height + Width).MaxValueCheck();
    }
}