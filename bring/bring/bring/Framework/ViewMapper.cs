using bring.View;
using bring.ViewModel;
using Xamarin.Forms;


namespace bring.Framework
{
    public class ViewMapper : IViewMapper
    {
        public Page Map<TViewModel>(TViewModel viewModel) where TViewModel : class
        {
            Page result = null;
            switch (viewModel)
            {
                case MainViewModel mainViewModel:
                    result = new MainPage();
                    result.BindingContext = mainViewModel;
                    break;
                case BringListViewModel listViewModel:
                    result = new ListPage();
                    result.BindingContext = listViewModel;
                    break;
                case BringItemViewModel detailViewModel:
                    result = new ItemDetailPage();
                    result.BindingContext = detailViewModel;
                    break;
            }
            return result;
        }
    }
}
