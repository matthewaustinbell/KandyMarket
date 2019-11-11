using System;
using System.Collections.Generic;
using System.Text;

namespace KandyMarket.Data
{
    public interface ICandyProvider
    {
        IEnumerable<Candy> Get();
    }
}
