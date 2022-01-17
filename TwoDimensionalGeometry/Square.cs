using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

public class Square:ITwoDimensionalShape
{
    public float Side { get; set; }

    public float GetArea() => Side * Side;
    
    public float GetPerimeter() => Side * 4;
}