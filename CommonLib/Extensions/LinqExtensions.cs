using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandson.Extensions
{
    public static class LinqExtensions
    {
        /// <summary>
        /// 前回値を第二引数に渡すSelect拡張
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="s"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static IEnumerable<T> SelectNm1<T>(this IEnumerable<T> s, Func<T,T,T> func)
        {
            T nm1 = default(T);
            foreach(var v in s)
            {
                yield return func(v, nm1);
                nm1 = v;
            }
        }
    }
}
