using System.Threading.Tasks;

namespace AspNetCoreMini.Http
{
    public delegate Task RequestDelegate(HttpContext context);
}
