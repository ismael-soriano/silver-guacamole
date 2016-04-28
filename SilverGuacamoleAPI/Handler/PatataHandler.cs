using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace SilverGuacamoleAPI.Handler
{
    public class PatataHandler : DelegatingHandler
    {
        const string VUELING_HEADER = "X-Vueling";

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Headers.Contains(VUELING_HEADER))
            {
                var value = request.Headers.GetValues(VUELING_HEADER).FirstOrDefault();
                int parseValue;

                if (int.TryParse(value, out parseValue))
                {
                    parseValue = parseValue * 2;
                }

                return base.SendAsync(request, cancellationToken).ContinueWith(t =>
                {
                    HttpResponseMessage resp = t.Result;
                    resp.Headers.Add(VUELING_HEADER, parseValue.ToString());
                    return resp;
                });
            }

            return base.SendAsync(request, cancellationToken);
        }

    
    }
}