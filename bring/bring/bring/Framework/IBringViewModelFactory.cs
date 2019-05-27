using bring.Model;
using bring.ViewModel;

namespace bring.Framework
{
    public interface IBringViewModelFactory
    {
        BringItemViewModel Create(BringItem item, BringListViewModel listViewModel);
    }
}
