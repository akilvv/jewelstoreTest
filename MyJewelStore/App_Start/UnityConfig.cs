using MyJewelStore.BusinessLogic;
using MyJewelStore.Common;
using MyJewelStore.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MyJewelStore
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IAuthService, AuthService>();
            container.RegisterType<IPricingService, PricingService>();
            container.RegisterType<IPrintEstimationService, PrintEstimationService>();

            container.RegisterType<IDataRepository, DataRepository>();

            container.RegisterType<IHelper, Helper>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}