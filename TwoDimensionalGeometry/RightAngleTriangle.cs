// -----------------------------------------------------------------------------------------------
//  TriangleRightAngle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

public class RightAngleTriangle:ITwoDimensionalShape
{
    public float Height { get; set; }
    public float Width { get; set; }
    public float GetArea() => Height <= 0 || Width <= 0 ? -1 : (Height * Width) / 2;

    public float GetPerimeter()
    {
        if (Height <= 0 || Width <= 0) return -1;
        else
        {
            var hypotenuse = (float)Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
            return hypotenuse + Height + Width;
        }
    }
}