using System.Collections.Generic;
using System.Linq;
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

        public Query<T> Query<T>() where T : IRegularCollection
            => new Query<T>(this);

        public BareQuery<T> Query<T>(Server world, params Continent[] zones) where T : Map
            => new BareQuery<T>(this).AddQuery("world_id", (int)world).AddQuery("zone_ids", string.Join(",", zones.Cast<int>()));

        internal async Task<List<T>> GetAsync<T>(QueryParamCollection queryParameters)
            where T : ICollection
        {
            JObject result = await ApiUtilities
                .GetUrl<T>(Platform, queryParameters, isExample: false)
                .GetJsonAsync<JObject>()
                .ConfigureAwait(false);

            return result.First.First.ToObject<List<T>>();
        }

        internal async Task<int> CountAsync<T>(QueryParamCollection queryParameters)
            where T : ICountableCollection
        {
            JObject result = await ApiUtilities
                .GetCountUrl<T>(Platform, queryParameters, isExample: false)
                .GetJsonAsync<JObject>()
                .ConfigureAwait(false);

            return result.First.ToObject<int>();
        }
    }
}
