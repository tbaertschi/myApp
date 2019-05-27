﻿using bring.Model;
using Xamarin.Forms;

namespace bring.ViewModel
{
    public class BringItemViewModel : BaseViewModel
    {

        /// <inheritdoc />
        public BringItemViewModel(INavigation _navigation, BringListViewModel _listViewModel, BringItem _bringItem)
        {
            navigation = _navigation;
            listViewModel = _listViewModel;
            bringItem = _bringItem;
        }

        public string Name
        {
            get => bringItem.Name;
            set
            {
                bringItem.Name = value;
                RaisePropertyChanged();
            }
        }

        public string Note
        {
            get => bringItem.Note;
            set
            {
                bringItem.Note = value;
                RaisePropertyChanged();
            }
        }

        public bool IsNeeded
        {
            get => bringItem.IsNeeded;
            set
            {
                bringItem.IsNeeded = value;
                RaisePropertyChanged();
            }
        }


        private readonly INavigation navigation;
        private readonly BringListViewModel listViewModel;
        private BringItem bringItem;
    }
}