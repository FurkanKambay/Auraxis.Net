using Auraxis.Net.Helpers;
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
            var listName = ApiUtilities.GetCollectionName<T>() + "_list";

            JObject result = await ApiUtilities
                .GetUrl<T>(platform)
                .SetQueryParam("c:limit", limit)
                .GetJsonAsync<JObject>()
                .ConfigureAwait(false);

            return result[listName].ToObject<List<T>>();
        }

        public static async Task<int> CountAsync<T>(Platform platform)
        {
            JObject result = await ApiUtilities
                .GetCountUrl<T>(platform)
                .GetJsonAsync<JObject>()
                .ConfigureAwait(false);

            return result.First.ToObject<int>();
        }
    }
}
