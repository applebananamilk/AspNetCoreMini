using System;
using System.Collections.Generic;

namespace AspNetCoreMini.Features
{
    public interface IFeatureCollection : IDictionary<Type, object>
    {
    }
}
