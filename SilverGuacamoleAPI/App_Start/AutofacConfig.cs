using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SilverGuacamoleAPI.Controllers;
using Services;
using Infraestructure;

namespace SilverGuacamoleAPI.App_Start
{
    public class AutofacConfig
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterType<CustomerController>().As<Controller>().InstancePerHttpRequest();
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerHttpRequest();
            builder.RegisterType<AppContext>().As<IRepositoryCustomer>().InstancePerHttpRequest();
            builder.RegisterModelBinderProvider();
            return builder.Build();
        }
    }
}