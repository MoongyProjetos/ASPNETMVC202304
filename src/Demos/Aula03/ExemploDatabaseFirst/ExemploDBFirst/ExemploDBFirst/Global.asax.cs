using StackExchange.Profiling;
using StackExchange.Profiling.EntityFramework6;
using StackExchange.Profiling.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ExemploDBFirst
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            MiniProfiler.Configure(new MiniProfilerOptions { }.AddViewProfiling());
            MiniProfilerEF6.Initialize();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest()
        {
            MiniProfiler.StartNew();
        }

        protected void Application_EndRequest()
        {
            MiniProfiler.Current?.Stop();
        }
    }
}
