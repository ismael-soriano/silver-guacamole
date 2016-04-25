using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using SilveGuacamole.Controllers;
using Services;



namespace SilverGuacamole.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(SilverGuacamole.MvcApplication).Assembly);

            builder.RegisterModelBinders(typeof(SilverGuacamole.MvcApplication).Assembly);
            // Register our Data dependencies
            builder.RegisterModule<AutofacWebTypesModule>();

            builder.RegisterType<CustomerController>().As<Controller>().InstancePerHttpRequest();

            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerHttpRequest();

            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerHttpRequest();

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }


    }
}