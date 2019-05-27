using Xamarin.Forms;

namespace bring.Framework
{
    public interface IViewMapper
    {
        Page Map<TViewModel>(TViewModel viewModel) where TViewModel : class;
    }
}
