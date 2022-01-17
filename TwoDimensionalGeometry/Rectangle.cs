// -----------------------------------------------------------------------------------------------
//  Rectangle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

public class Rectangle : ITwoDimensionalShape
{
    public float Height { get; set; }
    public float Width { get; set; }
    public float GetArea() => Height < 0 || Width < 0 ? -1 : Height * Width;

    public float GetPerimeter() => Height < 0 || Width < 0 ? -1 : Height * 2 + Width * 2;
}