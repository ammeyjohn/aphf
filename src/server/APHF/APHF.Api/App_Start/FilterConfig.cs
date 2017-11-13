using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APHF.Api
{
    /// <summary>
    /// 用于向WebApi注册Filter对象
    /// </summary>
    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(HttpConfiguration config)
        {
            GlobalConfiguration.Configuration.Filters.Add(new AphfExceptionFilterAttribute());
        }
    }
}