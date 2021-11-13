using AspNetCoreMini.Features;
using AspNetCoreMini.Http;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AspNetCoreMini.Hosting
{
    public class HttpListenerServer : IServer
    {
        private readonly HttpListener _httpListener;
        private readonly string[] _urls;

        public HttpListenerServer(params string[] urls)
        {
            _httpListener = new HttpListener();
            _urls = urls.Any() ? urls : new string[] { "http://localhost:5000/" };
        }

        public async Task StartAysnc(RequestDelegate handler)
        {
            Array.ForEach(_urls, url => _httpListener.Prefixes.Add(url));
            _httpListener.Start();
            while (true)
            {
                HttpListenerContext listenerContext = await _httpListener.GetContextAsync();
                HttpListenerFeature feature = new HttpListenerFeature(listenerContext);
                IFeatureCollection features = new FeatureCollection()
                    .Set<IHttpRequestFeature>(feature)
                    .Set<IHttpResponseFeature>(feature);
                HttpContext httpContext = new HttpContext(features);
                await handler(httpContext);
                listenerContext.Response.Close();
            }
        }
    }
}
