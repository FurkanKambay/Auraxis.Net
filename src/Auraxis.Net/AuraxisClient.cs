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

        public Query<T> Query<T>() where T : ICollection
            => new Query<T>(this);

        internal async Task<List<T>> GetAsync<T>(QueryParamCollection queryParameters)
            where T : ICollection
        {
            JObject result = await ApiUtilities
                .GetUrl<T>(Platform, queryParameters)
                .GetJsonAsync<JObject>()
                .ConfigureAwait(false);

            var listName = ApiUtilities.GetCollectionName<T>() + "_list";
            return result[listName].ToObject<List<T>>();
        }

        internal async Task<int> CountAsync<T>(QueryParamCollection queryParameters)
            where T : ICountableCollection
        {
            JObject result = await ApiUtilities
                .GetCountUrl<T>(Platform, queryParameters)
                .GetJsonAsync<JObject>()
                .ConfigureAwait(false);

            return result.First.ToObject<int>();
        }
    }
}
