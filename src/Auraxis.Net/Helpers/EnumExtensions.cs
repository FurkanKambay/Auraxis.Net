using System;

namespace Auraxis.Net.Helpers
{
    internal static class EnumExtensions
    {
        internal static string GetNamespaceString(this Platform value)
        {
            switch (value)
            {
                case Platform.PC:
                    return "ps2:v2";
                case Platform.PS4_EU:
                    return "ps2ps4eu:v2";
                case Platform.PS4_US:
                    return "ps2ps4us:v2";
                default:
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
    }
}
