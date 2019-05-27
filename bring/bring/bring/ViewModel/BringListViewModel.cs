using System.Collections.ObjectModel;
using System.Windows.Input;
using bring.Framework;
using bring.Model;
using Xamarin.Forms;

namespace bring.ViewModel
{
    public class BringListViewModel : BaseViewModel
    {

        private ObservableCollection<BringItemViewModel> Items { get; set; }

        public BringListViewModel(INavigation navigation, IViewMapper viewMapper)
        {
            _navigation = navigation;
            _viewMapper = viewMapper;

            Items =new ObservableCollection<BringItemViewModel>();
            NavigateCommand = new Command(() =>
            {
                var viewModel= new BringItemViewModel( new BringItem());
                _navigation.PushAsync(_viewMapper.Map(viewModel));
            });

        }

        public ICommand NavigateCommand { get;  }


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
