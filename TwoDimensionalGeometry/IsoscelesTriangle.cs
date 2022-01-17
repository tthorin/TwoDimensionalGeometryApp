// -----------------------------------------------------------------------------------------------
//  IsoscelesTriangle.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

public class IsoscelesTriangle:ITwoDimensionalShape
{
    public float Legs { get; set; }
    public float Base { get; set; }
    
    public float GetArea()
    {
        if (Legs <= 0 || Base >= Legs * 2||Base<=0) return -1;
        else
        {
            var height = (float) (Math.Sqrt(Math.Pow(Legs, 2) - Math.Pow(Base, 2) / 4));
            return (Base * height) / 2;
        }
    }

    public float GetPerimeter() => Base >= Legs * 2 || Legs <= 0 || Base <= 0 ? -1 : Base + Legs * 2;
}