using Flurl;
using System;

namespace Auraxis.Net.Helpers
{
    internal static class Constants
    {
        internal const string CensusBaseUrl = "https://census.daybreakgames.com";
        internal const string ServiceId = "s:AuraxisNet";
        internal const string VerbGet = "get";
        internal const string VerbCount = "count";
    }

    internal static class ApiUtilities
    {
        internal static Url GetCountUrl(Platform platform) =>
            GetDataUrl(Constants.VerbCount, platform);

        internal static Url GetGetUrl(Platform platform) =>
            GetDataUrl(Constants.VerbGet, platform);

        private static Url GetDataUrl(string verb, Platform platform)
        {
            return Constants.CensusBaseUrl.AppendPathSegments(
                Constants.ServiceId,
                verb.ToString().ToLower(),
                platform.GetNamespaceString()
            );
        }
    }

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
