using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;

namespace AW.Web.Api
{
    public class CustomMessageHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
            return base.SendAsync(request, cancellationToken);
        }
    }
}