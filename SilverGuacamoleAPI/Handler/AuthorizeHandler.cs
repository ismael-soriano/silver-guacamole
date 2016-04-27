using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Web;

namespace SilverGuacamoleAPI.Handler
{
    public class OAuthIdentity : IIdentity
    {

        public string AuthenticationType
        {
            get { return "Tiene que implementar atenticacion Bearer"; }
        }

        public bool IsAuthenticated
        {
            get { return true; /* :D */ }
        }

        public string Name
        {
            get { return "Andres"; }
        }
    }

    public class OAuthAuthorize : IPrincipal
    {

        public IIdentity Identity
        {
            get { return new OAuthIdentity(); }
        }

        public bool IsInRole(string role)
        {
            return true; // :D
        }
    }

    public class AuthorizeHandler : DelegatingHandler
    {
        protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Thread.CurrentPrincipal = new OAuthAuthorize();
            return base.SendAsync(request, cancellationToken);
        }
    }
}