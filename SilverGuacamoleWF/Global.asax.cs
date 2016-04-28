using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using SilverGuacamoleWF;
using Autofac.Integration.Web;
using SilverGuacamoleWF.App_Start;

namespace SilverGuacamoleWF
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        static IContainerProvider _containerProvider;

        /// <summary>
        /// Necesario para trabajar con Autofac
        /// </summary>
        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

        void Application_Start(object sender, EventArgs e)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            _containerProvider = new ContainerProvider(AutofacConfig.GetBuilder());
        }
    }
}
