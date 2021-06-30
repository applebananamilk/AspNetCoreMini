using AspNetCoreMini.Builder;
using System;

namespace AspNetCoreMini.Hosting
{
    public interface IWebHostBuilder
    {
        IWebHostBuilder UseServer(IServer server);
        IWebHostBuilder Configure(Action<IApplicationBuilder> configura);
        IWebHost Build();
    }
}
