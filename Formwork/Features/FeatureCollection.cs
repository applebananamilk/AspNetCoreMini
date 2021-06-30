using System;
using System.Collections.Generic;

namespace AspNetCoreMini.Features
{
    public class FeatureCollection : Dictionary<Type, object>, IFeatureCollection
    {
    }
}
