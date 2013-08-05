using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace GlimpseAndUrlRewirite.RewriteTarget.Controllers
{
    public class HomeController : ApiController
    {
        public string Get()
        {
            return "Ok";
        }


        // POST api/values
        public HttpResponseMessage Post(HttpRequestMessage request)
        {
            string content = request.Content.ReadAsStringAsync().Result;
            return new HttpResponseMessage()
                {
                    Content = new StringContent(content)
                        {
                            Headers = {ContentType = new MediaTypeHeaderValue("text/plain")}
                        }
                };
        }
    }
}