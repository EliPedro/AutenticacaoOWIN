using OwinAuthentication.App_Start;
using OwinAuthentication.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OwinAuthentication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            BundleTable.EnableOptimizations = true;
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            //ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());

            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;

            Application["App"] = "ASP. NET Identity e a autenticação com componentes OWIN";
        }
    }
}
