using Auraxis.Net.Helpers;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Auraxis.Net
{
    public static class AuraxisClient
    {
        public static async Task<List<T>> GetAsync<T>(Platform platform, int limit = 1)
        {
            (var collectionName, var listName) = GetCollectionName<T>();

            Url url = ApiUtilities.GetGetUrl(platform)
                .AppendPathSegment(collectionName)
                .SetQueryParam("c:limit", limit);

            JObject result = await url.GetJsonAsync<JObject>().ConfigureAwait(false);
            return result[listName].ToObject<List<T>>();
        }

        public static async Task<int> CountAsync<T>(Platform platform)
        {
            (var name, _) = GetCollectionName<T>();

            Url url = ApiUtilities.GetCountUrl(platform)
                .AppendPathSegment(name);

            JObject result = await url.GetJsonAsync<JObject>().ConfigureAwait(false);
            return result.First.ToObject<int>();
        }

        private static (string name, string listName) GetCollectionName<T>()
        {
            var name = Regex.Replace(typeof(T).Name, "(?!^)([A-Z0-9])", "_$1").ToLowerInvariant();
            return (name, $"{name}_list");
        }
    }
}
