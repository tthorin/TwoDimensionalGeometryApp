// -----------------------------------------------------------------------------------------------
//  Circle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

public class Circle : ITwoDimensionalShape
{
    public float Radius { get; set; }

    public float Diameter
    {
        get => Radius * 2;
        set => Radius = value / 2;
    }

    public float GetArea() => Radius <= 0 ? -1 : (float) (Math.PI * Math.Pow(Radius, 2));

    public float GetPerimeter() => Radius <= 0 ? -1 : (float) (2 * Math.PI * Radius);
}