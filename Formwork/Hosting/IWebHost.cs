using System.Threading.Tasks;

namespace AspNetCoreMini.Hosting
{
    public interface IWebHost
    {
        Task StartAsync();
    }
}
