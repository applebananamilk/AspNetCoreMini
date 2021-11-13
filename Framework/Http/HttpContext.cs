using AspNetCoreMini.Features;

namespace AspNetCoreMini.Http
{
    public class HttpContext
    {
        public HttpContext(IFeatureCollection features)
        {
            Requert = new HttpRequert(features);
            Response = new HttpResponse(features);
        }

        public HttpRequert Requert { get; }

        public HttpResponse Response { get; }
    }
}
