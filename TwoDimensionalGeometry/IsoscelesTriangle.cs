// -----------------------------------------------------------------------------------------------
//  IsoscelesTriangle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Extensions;
using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

/// <summary>
///     Object that stores or calculates the characteristics for an isosceles triangle (triangle with two sides same
///     length).
/// </summary>
/// <seealso cref="TwoDimensionalGeometry.Interfaces.ITwoDimensionalShape" />
public class IsoscelesTriangle : ITwoDimensionalShape
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IsoscelesTriangle" /> class.
    /// </summary>
    /// <param name="tbase">The length of the triangles base.</param>
    /// <param name="legs">The length of the triangles legs.</param>
    public IsoscelesTriangle(float tbase = 0, float legs = 0)
    {
        Base = tbase;
        Legs = legs;
    }

    /// <summary>
    ///     Gets or sets the length of the legs (the two sides of the triangle with the same length).
    /// </summary>
    /// <value>
    ///     The length of the legs.
    /// </value>
    public float Legs { get; set; }

    /// <summary>
    ///     Gets or sets the length of the base of the triangle.
    /// </summary>
    /// <value>
    ///     The length of the triangles base.
    /// </value>
    public float Base { get; set; }

    /// <summary>
    ///     Gets the area.
    /// </summary>
    /// <returns>The calculated area, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetArea()
    {
        if (Legs <= 0 || Base >= Legs * 2 || Base <= 0) return -1;

        var height = (float) Math.Sqrt(Math.Pow(Legs, 2) - Math.Pow(Base, 2) / 4);
        return (Base * height / 2).MaxValueCheck();
    }

    /// <summary>
    ///     Gets the perimeter.
    /// </summary>
    /// <returns>
    ///     The calculated perimeter, or 0 if result of calculation is too high, or -1 if a dimension is
    ///     negative/invalid(base same or longer than twice the length of the legs).
    /// </returns>
    public float GetPerimeter()
    {
        return Base >= Legs * 2 || Legs <= 0 || Base <= 0 ? -1 : (Base + Legs * 2).MaxValueCheck();
    }
}