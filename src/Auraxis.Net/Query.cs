using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Auraxis.Net.Helpers;
using Flurl;

namespace Auraxis.Net
{
    public class Query<T> : BareQuery<T> where T : IRegularCollection
    {
        public Url CountUrl => ApiUtilities.GetCountUrl<T>(Client.Platform, QueryParameters);

        internal Query(AuraxisClient client) : base(client) { }

        internal new Query<T> AddQuery(string key, object value)
        {
            base.AddQuery(key, value);
            return this;
        }

        public WhereSelector<T, TField> Where<TField>(Expression<Func<T, TField>> fieldSelector)
            => new WhereSelector<T, TField>(this, fieldSelector.GetJsonPath<TField>());

        public Query<T> Skip(int count)
            => AddQuery("c:start", count);

        public Query<T> Take(int count)
            => AddQuery("c:limit", count);

        public Query<T> TakePerDatabase(int count)
            => AddQuery("c:limitPerDB", count);

        public Query<T> OrderBy<TField>(Expression<Func<T, TField>> fieldSelector)
            => AddQuery("c:sort", fieldSelector.GetJsonPath<TField>());

        public Query<T> OrderByDescending<TField>(Expression<Func<T, TField>> fieldSelector)
            => AddQuery("c:sort", $"{fieldSelector.GetJsonPath<TField>()}:-1");

        public Query<T> ThatHas<TField>(Expression<Func<T, TField>> fieldSelector)
            => AddQuery("c:has", fieldSelector.GetJsonPath<TField>());
    }

    public class BareQuery<T> where T : ICollection
    {
        internal readonly AuraxisClient Client;
        internal readonly QueryParamCollection QueryParameters = new QueryParamCollection();

        internal BareQuery<T> AddQuery(string key, object value)
        {
            QueryParameters.Add(key, value);
            return this;
        }

        internal BareQuery(AuraxisClient client) => Client = client;

        public Url Url => ApiUtilities.GetUrl<T>(Client.Platform, QueryParameters);

        public async Task<List<T>> GetAsync() => await Client.GetAsync<T>(QueryParameters).ConfigureAwait(false);
    }

    public static class QueryExtensions
    {
        public static async Task<int> CountAsync<T>(this Query<T> self) where T : ICountableCollection
            => await self.Client.CountAsync<T>(self.QueryParameters).ConfigureAwait(false);
    }
}
