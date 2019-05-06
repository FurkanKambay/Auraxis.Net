using Auraxis.Net.Helpers;
using Flurl;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auraxis.Net
{
    public class Query<T>
    {
        private readonly AuraxisClient client;
        private readonly QueryParamCollection queryParameters = new QueryParamCollection();

        internal Query(AuraxisClient client) => this.client = client;

        internal Query<T> AddQuery(string key, object value)
        {
            queryParameters.Add(key, value);
            return this;
        }

        public Url Url => ApiUtilities.GetUrl<T>(client.Platform, queryParameters);
        public Url CountUrl => ApiUtilities.GetCountUrl<T>(client.Platform, queryParameters);

        public Query<T> Skip(int amount) => AddQuery("c:start", amount);
        public Query<T> Take(int limit) => AddQuery("c:limit", limit);
        public Query<T> TakePerDatabase(int limitPerDb) => AddQuery("c:limitPerDB", limitPerDb);

        public async Task<List<T>> GetAsync() => await client.GetAsync<T>(queryParameters).ConfigureAwait(false);
        public async Task<int> CountAsync() => await client.CountAsync<T>(queryParameters).ConfigureAwait(false);
    }
}
