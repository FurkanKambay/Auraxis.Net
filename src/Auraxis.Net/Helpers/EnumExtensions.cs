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
                    return Constants.NamespacePC;
                case Platform.PS4_EU:
                    return Constants.NamespacePS4_EU;
                case Platform.PS4_US:
                    return Constants.NamespacePS4_US;
                default:
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
    }
}
