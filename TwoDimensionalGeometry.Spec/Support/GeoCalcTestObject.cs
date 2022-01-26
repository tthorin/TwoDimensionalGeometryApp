// -----------------------------------------------------------------------------------------------
//  GeoCalcTestObject.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace TwoDimensionalGeometry.Spec.Support;

using System.Collections.Generic;
using TwoDimensionalGeometry.Interfaces;

internal class GeoCalcTestObject
{
    public List<ITwoDimensionalShape> Shapes { get; set; } = new();
    public List<float> ResultsArea { get; set; } = new();
    public List<float> ResultsPerimeter { get; set; } = new();
    public float TotalArea { get; set; }
    public float TotalPerimeter { get; set; }
}
