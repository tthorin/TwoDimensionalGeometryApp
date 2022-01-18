// -----------------------------------------------------------------------------------------------
//  FloatHelper.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace TwoDimensionalGeometry.Helpers;

internal static class FloatHelper
{
    internal static float MaxValueCheck(float number) => number >= float.MaxValue ? 0 : number;
}