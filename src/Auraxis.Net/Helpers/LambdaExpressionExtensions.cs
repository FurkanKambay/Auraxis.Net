using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Newtonsoft.Json;

namespace Auraxis.Net.Helpers
{
    internal static class LambdaExpressionExtensions
    {
        internal static string GetFieldName(this LambdaExpression self)
        {
            var result = new Stack<string>();
            Expression current = self.Body;

            while (true)
            {
                switch (current)
                {
                    case MemberExpression me:
                        result.Push(me.Member.GetJsonName());
                        current = me.Expression;
                        continue;
                    case ParameterExpression _ when result.Count > 0:
                        return string.Join(".", result);
                    default:
                        throw new NotSupportedException("Only MemberAccess expressions are supported in Expressions.");
                }
            }
        }

        internal static string GetJsonName(this MemberInfo self) =>
            self.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ?? self.Name.ToLowerInvariant();
    }
}
