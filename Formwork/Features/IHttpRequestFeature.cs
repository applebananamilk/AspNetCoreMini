using System.Collections.Specialized;
using System.IO;
using System;

namespace AspNetCoreMini.Features
{
    public interface IHttpRequestFeature
    {
        public Uri Url { get; }
        public NameValueCollection Headers { get; }
        public Stream Body { get; }
    }
}
