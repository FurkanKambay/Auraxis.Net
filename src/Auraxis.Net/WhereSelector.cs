using System;

namespace Auraxis.Net
{
    public class WhereSelector<TCollection, TField> where TCollection : IRegularCollection
    {
        internal readonly Query<TCollection> Query;
        internal readonly string FieldName;

        public WhereSelector(Query<TCollection> query, string fieldName)
        {
            Query = query;
            FieldName = fieldName;
        }

        public Query<TCollection> IsEqualTo(TField value) => AddQuery(value);
        public Query<TCollection> IsNotEqualTo(TField value) => AddQuery(value, "!");

        private Query<TCollection> AddQuery(TField value, string prefix = null)
        {
            return value is Enum
                ? Query.AddQuery(FieldName, prefix + value.GetHashCode())
                : Query.AddQuery(FieldName, prefix + value);
        }
    }
}
