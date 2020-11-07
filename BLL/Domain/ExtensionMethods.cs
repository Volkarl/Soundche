﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soundche.Core.Domain
{
    public static class ExtensionMethods
    {
        public static IEnumerable<double> CumulativeSum(this IEnumerable<double> sequence)
        {
            double sum = 0;
            foreach (var item in sequence)
            {
                sum += item;
                yield return sum;
            }
        }

        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return list == null || list.Count == 0;
        }

        public static IEnumerable<T> OrEmptyIfNull<T>(this IEnumerable<T> source)
        {
            return source ?? System.Linq.Enumerable.Empty<T>();
        }

        public static void ReplaceFirst<T>(this List<T> lst, Predicate<T> predicate, T newItem)
        {
            lst[lst.FindIndex(predicate)] = newItem;
        }
    }
}
