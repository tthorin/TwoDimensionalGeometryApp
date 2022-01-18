// -----------------------------------------------------------------------------------------------
//  Circle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;
using static TwoDimensionalGeometry.Helpers.FloatHelper;

namespace TwoDimensionalGeometry;

public class Circle : ITwoDimensionalShape
{
    public float Radius { get; set; }

    public float Diameter
    {
        get => Radius * 2;
        set => Radius = value / 2;
    }

    public float GetArea()
    {
        var area =  Radius <= 0 ? -1 : (float) (Math.PI * Math.Pow(Radius, 2));
        return MaxValueCheck(area);
    }

    public float GetPerimeter()
    {
        var perimeter =Radius <= 0 ? -1 : (float) (2 * Math.PI * Radius);
        return MaxValueCheck(perimeter);
    }
}