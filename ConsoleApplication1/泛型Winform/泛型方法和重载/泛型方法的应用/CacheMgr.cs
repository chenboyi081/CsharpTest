using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型.泛型方法.泛型方法的应用
{
    using System.Web;

    public class CacheMgr
    {
        /// <returns></returns>
        public static T GetData<T>(string cachekey)
        {
            return (T)HttpRuntime.Cache[cachekey];
        }
    }
}
