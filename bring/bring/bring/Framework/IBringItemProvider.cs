using System.Collections.Generic;
using bring.Model;

namespace bring.Framework
{
    public interface IBringItemProvider
    {
        IEnumerable<BringItem> Load();
    }
}
