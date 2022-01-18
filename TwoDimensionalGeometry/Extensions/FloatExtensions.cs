// -----------------------------------------------------------------------------------------------
//  FloatHelper.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace TwoDimensionalGeometry.Extensions;

internal static class FloatExtensions
{
    internal static float MaxValueCheck(this float number)
    {
        return number >= float.MaxValue ? 0 : number;
    }
}