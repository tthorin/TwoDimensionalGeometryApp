using TwoDimensionalGeometry.Interfaces;

namespace TwoDimensionalGeometry;

public class Square : ITwoDimensionalShape
{
    public float Side { get; set; }

    public float GetArea() => Side <= 0 ? -1 : Side * Side;

    public float GetPerimeter() => Side <= 0 ? -1 : Side * 4;
}