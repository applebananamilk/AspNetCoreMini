using AspNetCoreMini.Http;
using System.Threading.Tasks;

namespace AspNetCoreMini.Hosting
{
    public interface IServer
    {
        Task StartAysnc(RequestDelegate handler);
    }
}
