using AspNetCoreMini.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreMini.Hosting
{
    public class WebHostBuilder : IWebHostBuilder
    {
        private IServer _server;
        private readonly List<Action<IApplicationBuilder>> _configuras = new List<Action<IApplicationBuilder>>();

        public IWebHostBuilder Configure(Action<IApplicationBuilder> configura)
        {
            _configuras.Add(configura);
            return this;
        }

        public IWebHostBuilder UseServer(IServer server)
        {
            _server = server;
            return this;
        }

        public IWebHost Build()
        {
            IApplicationBuilder builder = new ApplicationBuilder();
            foreach (var configura in _configuras)
            {
                configura(builder);
            }
            return new WebHost(_server, builder.Build());
        }


    }
}
