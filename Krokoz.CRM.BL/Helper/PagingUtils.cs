using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krokoz.CRM.BL.Helper
{
    /// <summary>
    /// Paging Utils
    /// </summary>
    public static class PagingUtils
    {
        /// <summary>
        /// Page
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="en"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static IEnumerable<T> Page<T>(this IEnumerable<T> en, int pageSize, int page) where T : class
        {
            return en.Skip(page * pageSize).Take(pageSize);
        }

        /// <summary>
        /// Page
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="en"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static IQueryable<T> Page<T>(this IQueryable<T> en, int pageSize, int page) where T : class
        {
            return en.Skip(page * pageSize).Take(pageSize);
        }
    }
}
