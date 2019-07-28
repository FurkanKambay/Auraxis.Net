using System.Text.RegularExpressions;
using Flurl;

namespace Auraxis.Net.Helpers
{
    internal static class ApiUtilities
    {
        internal static string GetCollectionName<T>()
            => Regex.Replace(typeof(T).Name, "(?!^)([A-Z0-9])", "_$1").ToLowerInvariant();

        internal static Url GetCountUrl<T>(Platform platform, QueryParamCollection queryParameters)
            => GetDataUrl<T>(Constants.VerbCount, platform, queryParameters);

        internal static Url GetUrl<T>(Platform platform, QueryParamCollection queryParameters)
            => GetDataUrl<T>(Constants.VerbGet, platform, queryParameters);

        private static Url GetDataUrl<T>(string verb, Platform platform, QueryParamCollection queryParameters)
        {
            return Constants.CensusBaseUrl.AppendPathSegments(
                Constants.ServiceId,
                verb,
                platform.GetNamespaceString(),
                GetCollectionName<T>()
            ).SetQueryParams(queryParameters);
        }
    }
}
