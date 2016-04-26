using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SilverGuacamoleAPI.Controllers;
using Services;
using Infraestructure;
using System.Web.Http;
using System.Reflection;

namespace SilverGuacamoleAPI.App_Start
{
    public class AutofacConfig
    {

        public static void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);

            
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerApiRequest();
            builder.RegisterType<AppContext>().As<IRepositoryCustomer>().InstancePerApiRequest();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}