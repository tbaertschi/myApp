﻿using System.Windows.Input;
using bring.Framework;
using Xamarin.Forms;

namespace bring.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(INavigation navigation, IViewMapper viewMapper, BringListViewModel listViewModel)
        {
            _navigation = navigation;
            _viewMapper = viewMapper;
            _listViewModel = listViewModel;
            NavigateCommand = new Command((parameter) => _navigation.PushAsync(_viewMapper.Map(listViewModel)));
        }

        public ICommand NavigateCommand { get; }

    private void Navigate()
        {
            var page = _viewMapper.Map(_listViewModel);
            _navigation.PushAsync(page);
        }

        private readonly INavigation _navigation;
        private readonly IViewMapper _viewMapper;
        private readonly BringListViewModel _listViewModel;
    }
}
