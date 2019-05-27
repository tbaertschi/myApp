using System.Collections.ObjectModel;
using bring.Framework;
using Xamarin.Forms;

namespace bring.ViewModel
{
    public class BringListViewModel : BaseViewModel
    {

        private ObservableCollection<BringItemViewModel> Items { get; set; }

        public BringListViewModel()
        {
            Items=new ObservableCollection<BringItemViewModel>();
        }

        public BringItemViewModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                RaisePropertyChanged();
            }
        }
        private readonly INavigation _navigation;
        private readonly IViewMapper _viewMapper;
        private readonly IBringViewModelFactory _viewModelFactory;
        private BringItemViewModel _selectedItem;
        private ObservableCollection<BringItemViewModel> _items;

    }
}
