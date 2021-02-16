using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyJewelStore.Models;
using System.Data.Entity;

namespace MyJewelStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new AccessModelContextInitilizer());
            AccessModelContext con = new AccessModelContext();
            con.Database.Initialize(true);
            con.Database.CreateIfNotExists();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            UnityConfig.RegisterComponents();
        }
    }
}
