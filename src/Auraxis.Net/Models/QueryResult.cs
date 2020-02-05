using System.Collections.Generic;
using Flurl;

namespace Auraxis.Net
{
    public class QueryResult<T>
    {
        public List<T> Results { get; internal set; }
        public Url QueriedUrl { get; internal set; }
        public int? Timing { get; internal set; }

        public QueryResult(List<T> results, Url url, int? timing = default)
        {
            Results = results;
            QueriedUrl = url;
            Timing = timing;
        }
    }
}
