using System;
using System.Collections.Generic;
using System.Linq;

namespace Swashbuckle.HeaderParameter.Extension.Extensions
{
    internal static class IEnumerableExtensions
    {
        internal static IEnumerable<T> Merge<T, TProperty>(this IEnumerable<T> source, Func<T, TProperty> selector)
        {
            return
                source
                    .GroupBy(selector)
                    .Select(x => x.Last());
        }
    }
}
