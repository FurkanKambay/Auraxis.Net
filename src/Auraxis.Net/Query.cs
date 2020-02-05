using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Auraxis.Net.Helpers;
using Flurl;

namespace Auraxis.Net
{
    public class Query<T>
    {
        private readonly AuraxisClient client;
        private readonly QueryParamCollection queryParameters = new QueryParamCollection();

        internal Query(AuraxisClient client)
        {
            this.client = client;
            queryParameters.Add("timing", true);
        }

        internal Query<T> AddQuery(string key, object value)
        {
            queryParameters.Add(key, value);
            return this;
        }

        public Url Url => ApiUtilities.GetUrl<T>(client.Platform, queryParameters);
        public Url CountUrl => ApiUtilities.GetCountUrl<T>(client.Platform, queryParameters);

        public WhereSelector<T, TField> Where<TField>(Expression<Func<T, TField>> fieldSelector)
            => new WhereSelector<T, TField>(this, fieldSelector.GetFieldName());

        public Query<T> Skip(int count)
            => AddQuery("c:start", count);

        public Query<T> Take(int count)
            => AddQuery("c:limit", count);

        public Query<T> TakePerDatabase(int count)
            => AddQuery("c:limitPerDB", count);

        public Query<T> OrderBy<TField>(Expression<Func<T, TField>> fieldSelector)
            => AddQuery("c:sort", fieldSelector.GetFieldName());

        public Query<T> OrderByDescending<TField>(Expression<Func<T, TField>> fieldSelector)
            => AddQuery("c:sort", $"{fieldSelector.GetFieldName()}:-1");

        public Query<T> ThatHas<TField>(Expression<Func<T, TField>> fieldSelector)
            => AddQuery("c:has", fieldSelector.GetFieldName());

        public async Task<QueryResult<T>> GetAsync() => await client.GetAsync<T>(queryParameters).ConfigureAwait(false);
        public async Task<int> CountAsync() => await client.CountAsync<T>(queryParameters).ConfigureAwait(false);
    }
}
