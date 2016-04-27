using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Threading;
using System.Threading.Tasks;

namespace SilverGuacamoleAPI.Handler
{
    public class PatataHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return base.SendAsync(request, cancellationToken).ContinueWith(task =>
            {
                var response = task.Result;
                response.Headers.Add("x-Dummy-Header", Guid.NewGuid().ToString());
                return response;
            });
        }
    }
}