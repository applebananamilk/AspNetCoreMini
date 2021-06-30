using AspNetCoreMini.Features;
using System;
using System.Collections.Specialized;
using System.IO;

namespace AspNetCoreMini.Http
{
    public class HttpRequert
    {
        private readonly IHttpRequestFeature _feature;
        public HttpRequert(IFeatureCollection features) => _feature = features.Get<IHttpRequestFeature>();


        public Uri Url => _feature.Url;
        public NameValueCollection Headers => _feature.Headers;
        public Stream Body => _feature.Body;
    }
}
