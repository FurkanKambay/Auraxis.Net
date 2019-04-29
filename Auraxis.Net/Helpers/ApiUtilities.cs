using Flurl;

namespace Auraxis.Net.Helpers
{
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
}
