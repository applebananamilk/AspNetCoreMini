using AspNetCoreMini.Http;
using System;

namespace AspNetCoreMini.Builder
{
    public interface IApplicationBuilder
    {
        IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
        RequestDelegate Build();
    }
}
