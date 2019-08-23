using System.Text.RegularExpressions;
using Flurl;

namespace Auraxis.Net.Helpers
{
    internal static class ApiUtilities
    {
        internal static string GetCollectionName<T>()
            => Regex.Replace(typeof(T).Name, "(?!^)([A-Z0-9])", "_$1").ToLowerInvariant();

        internal static Url GetEventStreamingUrl(Platform platform)
        {
            return Constants.EventStreamingBaseUrl
                .SetQueryParam("environment", platform.GetNamespaceString())
                .SetQueryParam("service-id", Constants.ServiceId);
        }

        internal static Url GetCountUrl<T>(Platform platform, QueryParamCollection queryParameters, bool isExample)
            => GetDataUrl<T>(Constants.VerbCount, platform, queryParameters, isExample);

        internal static Url GetUrl<T>(Platform platform, QueryParamCollection queryParameters, bool isExample)
            => GetDataUrl<T>(Constants.VerbGet, platform, queryParameters, isExample);

        private static Url GetDataUrl<T>(string verb, Platform platform, QueryParamCollection queryParameters, bool isExample)
        {
            return Constants.CensusBaseUrl.AppendPathSegments(
                isExample ? Constants.ExampleServiceId : Constants.ServiceId,
                verb,
                platform.GetNamespaceString(),
                GetCollectionName<T>()
            ).SetQueryParams(queryParameters);
        }
    }
}
