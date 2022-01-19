// -----------------------------------------------------------------------------------------------
//  Circle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;
using static TwoDimensionalGeometry.Extensions.FloatExtensions;

namespace TwoDimensionalGeometry;

/// <summary>
///     Object that stores or calculates the characteristics for a circle.
/// </summary>
/// <seealso cref="TwoDimensionalGeometry.Interfaces.ITwoDimensionalShape" />
public class Circle : ITwoDimensionalShape
{

    #region Public Properties

    /// <summary>
    ///     Gets or sets the diameter.
    /// </summary>
    /// <value>
    ///     The diameter.
    /// </value>
    public float Diameter
    {
        get => Radius * 2;
        set => Radius = value / 2;
    }

    /// <summary>
    ///     Gets or sets the radius.
    /// </summary>
    /// <value>
    ///     The radius.
    /// </value>
    public float Radius { get; set; }

    #endregion Public Properties

    #region Public Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="Circle" /> class.
    /// </summary>
    /// <param name="radius">The length of the circles radius.</param>
    public Circle(float radius = 0) => Radius = radius;

    #endregion Public Constructors

    #region Public Methods

    /// <summary>
    ///     Gets the area of the circle.
    /// </summary>
    /// <returns>The calculated area, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetArea()
    {
        var area = Radius <= 0 ? -1 : (float) (Math.PI * Math.Pow(Radius, 2));

        return area.MaxValueCheck();
    }

    /// <summary>
    ///     Gets the perimeter.
    /// </summary>
    /// <returns>The calculated perimeter, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetPerimeter()
    {
        var perimeter = Radius <= 0 ? -1 : (float) (2 * Math.PI * Radius);
        return perimeter.MaxValueCheck();
    }

    #endregion Public Methods

}