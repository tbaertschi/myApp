using bring.Model;
using bring.ViewModel;
using Xamarin.Forms;

namespace bring.Framework
{
    
        public class BringViewModelFactory : IBringViewModelFactory
        {
            public BringViewModelFactory(INavigation navigation)
            {
                _navigation = navigation;
            }

            public BringItemViewModel Create(BringItem item, BringListViewModel listViewModel)
            {
                return new BringItemViewModel( item);
            }

            private readonly INavigation _navigation;
        }
}
