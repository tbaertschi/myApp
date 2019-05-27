using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace bring.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Use this if a property has changed it's value to allow the UI to update.
        /// </summary>
        /// <param name="property">The property name - can be left empty if used in a setter.</param>
        protected void RaisePropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
