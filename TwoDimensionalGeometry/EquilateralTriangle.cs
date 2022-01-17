// -----------------------------------------------------------------------------------------------
//  EquilateralTriangle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

public class EquilateralTriangle:ITwoDimensionalShape
{
    public float Side { get; set; }
    public float GetArea() => Side <= 0 ? -1 : (float)(Math.Sqrt(3) / 4 * Math.Pow(Side, 2));

    public float GetPerimeter() => Side <= 0 ? -1 : Side * 3;
}