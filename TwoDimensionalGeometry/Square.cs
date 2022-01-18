using TwoDimensionalGeometry.Interfaces;
using static TwoDimensionalGeometry.Helpers.FloatHelper;

namespace TwoDimensionalGeometry;

public class Square : ITwoDimensionalShape
{
    public float Side { get; set; }

    public float GetArea() => Side <= 0 ? -1 : MaxValueCheck(Side * Side);

    public float GetPerimeter() => Side <= 0 ? -1 : MaxValueCheck(Side * 4);
}