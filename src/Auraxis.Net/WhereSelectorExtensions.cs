using System;

namespace Auraxis.Net
{
    public static class WhereSelectorExtensions
    {
        public static Query<T> Contains<T>(this WhereSelector<T, string> self, string value, bool exactMatchFirst = false)
            => self.Query.AddQuery(self.FieldName, $"*{value}").AddQuery("c:exactMatchFirst", exactMatchFirst);

        public static Query<T> StartsWith<T>(this WhereSelector<T, string> self, string value, bool exactMatchFirst = false)
            => self.Query.AddQuery(self.FieldName, $"^{value}").AddQuery("c:exactMatchFirst", exactMatchFirst);

        public static Query<T> IsGreaterThan<T, TField>(this WhereSelector<T, TField> self, TField value)
            where TField : struct, IComparable, IComparable<TField>, IConvertible, IEquatable<TField>, IFormattable
            => self.Query.AddQuery(self.FieldName, $">{value}");

        public static Query<T> IsGreaterThanOrEqualTo<T, TField>(this WhereSelector<T, TField> self, TField value)
            where TField : struct, IComparable, IComparable<TField>, IConvertible, IEquatable<TField>, IFormattable
            => self.Query.AddQuery(self.FieldName, $"]{value}");

        public static Query<T> IsLessThan<T, TField>(this WhereSelector<T, TField> self, TField value)
            where TField : struct, IComparable, IComparable<TField>, IConvertible, IEquatable<TField>, IFormattable
            => self.Query.AddQuery(self.FieldName, $"<{value}");

        public static Query<T> IsLessThanOrEqualTo<T, TField>(this WhereSelector<T, TField> self, TField value)
            where TField : struct, IComparable, IComparable<TField>, IConvertible, IEquatable<TField>, IFormattable
            => self.Query.AddQuery(self.FieldName, $"[{value}");
    }
}
