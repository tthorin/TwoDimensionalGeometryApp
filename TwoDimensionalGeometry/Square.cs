using TwoDimensionalGeometry.Extensions;
using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

/// <summary>
///     Object that stores or calculates the characteristics for a square.
/// </summary>
/// <seealso cref="TwoDimensionalGeometry.Interfaces.ITwoDimensionalShape" />
public class Square : ITwoDimensionalShape
{
    #region Public Properties

    /// <summary>
    ///     Gets or sets the length of the squares sides.
    /// </summary>
    /// <value>
    ///     The side.
    /// </value>
    public float Side { get; set; }

    #endregion Public Properties

    #region Public Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="Square" /> class.
    /// </summary>
    /// <param name="side">The length of the squares sides.</param>
    public Square(float side = 0) => Side = side;

    #endregion Public Constructors

    #region Public Methods

    /// <summary>
    ///     Gets the area.
    /// </summary>
    /// <returns>The calculated area, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetArea() => Side <= 0 ? -1 : (Side * Side).MaxValueCheck();

    /// <summary>
    ///     Gets the perimeter.
    /// </summary>
    /// <returns>The calculated perimeter, or 0 if result of calculation is too high, or -1 if a dimension is negative.</returns>
    public float GetPerimeter() => Side <= 0 ? -1 : (Side * 4).MaxValueCheck();

    #endregion Public Methods
}