using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AutoMapperWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapperWeb.Common.AutoMapperConfiguration.Configure();       //AutoMapperConfiguration为我们的静态配置入口类；如果是MVC，我们需要在Global中调用：如果没有这一句，会报“Mapper未初始化。使用适当的配置调用Initialize。”这样的错误

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
