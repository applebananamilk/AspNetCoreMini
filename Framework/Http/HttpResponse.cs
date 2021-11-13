using AspNetCoreMini.Features;
using System.Collections.Specialized;
using System.IO;

namespace AspNetCoreMini.Http
{
    public class HttpResponse
    {
        private readonly IHttpResponseFeature _feature;
        public HttpResponse(IFeatureCollection features) => _feature = features.Get<IHttpResponseFeature>();

        public int StatusCode { get; set; }
        public NameValueCollection Headers => _feature.Headers;
        public Stream Body => _feature.Body;
    }
}
