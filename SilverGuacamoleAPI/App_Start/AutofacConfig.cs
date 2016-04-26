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

namespace SilverGuacamoleAPI.App_Start
{
    public class AutofacConfig
    {
        public static IContainer ConfigureContainer()
        {
           var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterApiControllers(typeof(CustomerController).Assembly);
            //builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            //builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterType<CustomerController>().As<Controller>().InstancePerApiRequest();
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerApiRequest();
            builder.RegisterType<AppContext>().As<IRepositoryCustomer>().InstancePerApiRequest();
            //builder.RegisterModelBinderProvider();
            return builder.Build();
        }
    }
}