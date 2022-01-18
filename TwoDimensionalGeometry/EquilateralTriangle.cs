// -----------------------------------------------------------------------------------------------
//  EquilateralTriangle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;
using static TwoDimensionalGeometry.Helpers.FloatHelper;

namespace TwoDimensionalGeometry;

/// <summary>
/// Object that stores or calculates the characteristics for an equilateral triangle.
/// </summary>
/// <seealso cref="TwoDimensionalGeometry.Interfaces.ITwoDimensionalShape" />
public class EquilateralTriangle : ITwoDimensionalShape
{
    /// <summary>
    /// Gets or sets the length of the sides of the triangle.
    /// </summary>
    /// <value>
    /// The length of the triangles sides.
    /// </value>
    public float Side { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EquilateralTriangle"/> class.
    /// </summary>
    public EquilateralTriangle() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="EquilateralTriangle"/> class.
    /// </summary>
    /// <param name="side">The length of the triangles sides.</param>
    public EquilateralTriangle(float side) => Side = side;

    /// <summary>
    /// Gets the area.
    /// </summary>
    /// <returns>The calculated area, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetArea() => Side <= 0 ? -1 : MaxValueCheck((float)(Math.Sqrt(3) / 4 * Math.Pow(Side, 2)));

    /// <summary>
    /// Gets the perimeter.
    /// </summary>
    /// <returns>The calculated perimeter, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetPerimeter() => Side <= 0 ? -1 : MaxValueCheck(Side * 3);
}