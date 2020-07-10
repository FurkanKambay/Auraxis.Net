using System.Collections.Generic;
using System.Threading.Tasks;
using Auraxis.Net.Helpers;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json.Linq;

namespace Auraxis.Net
{
    public class AuraxisClient
    {
        internal readonly Platform Platform;

        internal AuraxisClient(Platform platform) => Platform = platform;

        public Query<T> Query<T>() => new Query<T>(this);

        internal async Task<QueryResult<T>> GetAsync<T>(QueryParamCollection queryParameters)
        {
            Url url = ApiUtilities.GetUrl<T>(Platform, queryParameters, isExample: false);
            JObject result = await url.GetJsonAsync<JObject>().ConfigureAwait(false);

            var timing = result[1].First.ToObject<int>();
            var results = result[2].First.ToObject<List<T>>();

            return new QueryResult<T>(results, url, timing);
        }

        internal async Task<int> CountAsync<T>(QueryParamCollection queryParameters)
        {
            JObject result = await ApiUtilities
                .GetCountUrl<T>(Platform, queryParameters, isExample: false)
                .GetJsonAsync<JObject>()
                .ConfigureAwait(false);

            return result.First.ToObject<int>();
        }
    }
}
