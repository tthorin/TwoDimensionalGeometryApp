// -----------------------------------------------------------------------------------------------
//  TriangleRightAngle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using static TwoDimensionalGeometry.Helpers.FloatHelper;
using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

public class RightAngleTriangle : ITwoDimensionalShape
{
    public float Height { get; set; }
    public float Width { get; set; }
    public float GetArea() => Height <= 0 || Width <= 0 ? -1 : MaxValueCheck(Height * Width / 2);

    public float GetPerimeter()
    {
        if (Height <= 0 || Width <= 0) return -1;

        var hypotenuse = (float) Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
        return MaxValueCheck(hypotenuse + Height + Width);
    }
}