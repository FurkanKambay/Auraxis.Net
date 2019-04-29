using Auraxis.Net.Helpers;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auraxis.Net
{
    public static class AuraxisClient
    {
        public static async Task<List<T>> GetAsync<T>(Platform platform, int limit = 1)
        {
            var collectionName = typeof(T).Name.ToLowerInvariant();

            Url url = ApiUtilities.GetGetUrl(platform)
                .AppendPathSegment(collectionName)
                .SetQueryParam("c:limit", limit);

            JObject result = await url.GetJsonAsync<JObject>().ConfigureAwait(false);
            return result[$"{collectionName}_list"].ToObject<List<T>>();
        }

        public static async Task<int> CountAsync<T>(Platform platform)
        {
            var collectionName = typeof(T).Name.ToLowerInvariant();

            Url url = ApiUtilities.GetCountUrl(platform)
                .AppendPathSegment(collectionName);

            JObject result = await url.GetJsonAsync<JObject>().ConfigureAwait(false);
            return result.First.ToObject<int>();
        }
    }
}
