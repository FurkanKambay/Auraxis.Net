using Flurl;
using System.Text.RegularExpressions;

namespace Auraxis.Net.Helpers
{
    internal static class ApiUtilities
    {
        internal static string GetCollectionName<T>()
            => Regex.Replace(typeof(T).Name, "(?!^)([A-Z0-9])", "_$1").ToLowerInvariant();

        internal static Url GetCountUrl<T>(Platform platform)
            => GetDataUrl<T>(Constants.VerbCount, platform);

        internal static Url GetUrl<T>(Platform platform)
            => GetDataUrl<T>(Constants.VerbGet, platform);

        private static Url GetDataUrl<T>(string verb, Platform platform)
        {
            return Constants.CensusBaseUrl.AppendPathSegments(
                Constants.ServiceId,
                verb.ToString().ToLower(),
                platform.GetNamespaceString(),
                GetCollectionName<T>());
        }
    }
}
