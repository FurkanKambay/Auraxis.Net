using Auraxis.Net.Helpers;
using Flurl.Http;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auraxis.Net
{
    public class AuraxisClient
    {
        internal readonly Platform Platform;

        internal AuraxisClient(Platform platform) => Platform = platform;

        public async Task<List<T>> GetAsync<T>(int limit = 1)
        {
            JObject result = await ApiUtilities
                .GetUrl<T>(Platform)
                .SetQueryParam("c:limit", limit)
                .GetJsonAsync<JObject>()
                .ConfigureAwait(false);

            var listName = ApiUtilities.GetCollectionName<T>() + "_list";
            return result[listName].ToObject<List<T>>();
        }

        public async Task<int> CountAsync<T>()
        {
            JObject result = await ApiUtilities
                .GetCountUrl<T>(Platform)
                .GetJsonAsync<JObject>()
                .ConfigureAwait(false);

            return result.First.ToObject<int>();
        }
    }
}
