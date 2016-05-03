using Autofac.Integration.Wcf;
using SilverGuacamoleWcfService.Configurations;
using System;
using System.Net;
using System.Web;

namespace SilverGuacamoleWcfService
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

            WebRequest.DefaultWebProxy = new WebProxy("127.0.0.1", 8888);
            AutofacHostFactory.Container = AutofacConfig.GetContainer();
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "POST, PUT, DELETE");

                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
                HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
                HttpContext.Current.Response.End();
            }
        }
    }
}