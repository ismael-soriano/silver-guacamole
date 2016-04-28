using Autofac;
using Infraestructure;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverGuacamoleWF.App_Start
{
    public class AutofacConfig
    {
        public static IContainer GetBuilder()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerRequest();
            builder.RegisterType<AppContext>().As<IRepositoryCustomer>().InstancePerRequest();

            return builder.Build();
        }
    }
}