using Autofac;
using Infraestructure;
using Services;
using SilverGuacamoleWcfService.Contracts;
using SilverGuacamoleWcfService.Services;

namespace SilverGuacamoleWcfService.Configurations
{
    public class AutofacConfig
    {
        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            // Register your service implementations.
            builder.RegisterType<CustomerServiceWcf>().As<ICustomerServiceWcf>();
            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<AppContext>().As<IRepositoryCustomer>();

            // Set the dependency resolver.
            return builder.Build();
        }
    }
}