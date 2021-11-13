using System.Collections.Specialized;
using System.IO;

namespace AspNetCoreMini.Features
{
    public interface IHttpResponseFeature
    {
        public int StatusCode { get; set; }
        public NameValueCollection Headers { get; }
        public Stream Body { get; }
    }
}
