using Flurl;
using System.Collections.Generic;

namespace Auraxis.Net.Helpers
{
    internal class Constants
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
        private static readonly Dictionary<Platform, string> platformPathMap = new Dictionary<Platform, string>
        {
            [Platform.PC] = "ps2:v2",
            [Platform.PS4_EU] = "ps2ps4eu:v2",
            [Platform.PS4_US] = "ps2ps4us:v2"
        };

        internal static string GetNamespaceString(this Platform value) => platformPathMap[value];
    }
}
