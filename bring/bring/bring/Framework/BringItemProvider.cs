using System.Collections.Generic;
using bring.Model;

namespace bring.Framework
{
    public class BringItemProvider : IBringItemProvider
    {
        public IEnumerable<BringItem> Load()
        {
            yield return new BringItem
            {
                Name = "Item 1",
                Note = "Special preferences about this Item...",
            };

            yield return new BringItem
            {
                Name = "Item 2",
                Note = "Special preferences about this Item...",
            };

            yield return new BringItem
            {
                Name = "Item 3",
                Note = "Special preferences about this Item...",
            };
        }
    }
}
