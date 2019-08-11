using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Newtonsoft.Json;

namespace Auraxis.Net.Helpers
{
    internal static class LambdaExpressionExtensions
    {
        internal static string GetJsonPath<T>(this LambdaExpression self)
        {
            var result = new Stack<string>();
            Expression current = self.Body;

            while (true)
            {
                switch (current)
                {
                    case BinaryExpression be when be.NodeType == ExpressionType.ArrayIndex && be.Left.NodeType == ExpressionType.MemberAccess:
                        var collection = self.Parameters[0].Type.Name;
                        MemberInfo member = (be.Left as MemberExpression)?.Member;
                        JsonArrayPathAttribute attribute = member.GetCustomAttribute<JsonArrayPathAttribute>();

                        if (attribute is null)
                            throw new NotSupportedException($"Indexer operator not supported on property {collection}.{member.Name}.");

                        T value = Evaluate<T>(be.Right);
                        result.Push(string.Format(attribute.Path, value));
                        current = be.Left;
                        continue;

                    case MemberExpression me:
                        result.Push(me.Member.GetJsonName());
                        current = me.Expression;
                        continue;

                    case ParameterExpression _ when result.Count > 0:
                        return string.Join(".", result);

                    default:
                        throw new NotSupportedException("Only MemberAccess and ArrayIndex expressions are supported.");
                }
            }
        }

        internal static string GetJsonName(this MemberInfo self) =>
            self.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ?? self.Name.ToLowerInvariant();

        private static T Evaluate<T>(Expression expression)
        {
            return expression.NodeType == ExpressionType.Constant
                ? (T)((ConstantExpression)expression).Value
                : Expression.Lambda<Func<T>>(expression).Compile().Invoke();
        }
    }
}
