using Autofac.Integration.Wcf;
using SilverGuacamoleWcfService.Configurations;
using System;
using System.Net;

namespace SilverGuacamoleWcfService
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

            WebRequest.DefaultWebProxy = new WebProxy("127.0.0.1", 8888);
            AutofacHostFactory.Container = AutofacConfig.GetContainer();
        }
    }
}