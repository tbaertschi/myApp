using bring.Model;
using bring.ViewModel;
using Xamarin.Forms;

namespace bring.Framework
{
    
        public class TodoViewModelFactory : IBringViewModelFactory
        {
            public TodoViewModelFactory(INavigation navigation)
            {
                _navigation = navigation;
            }

            public BringItemViewModel Create(BringItem item, BringListViewModel listViewModel)
            {
                return new BringItemViewModel(_navigation, listViewModel, item);
            }

            private readonly INavigation _navigation;
        }
}
