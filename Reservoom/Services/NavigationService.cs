using Reservoom.Stores;
using Reservoom.ViewModels;
using System;

namespace Reservoom.Services
{
    public class NavigationService
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<ViewModelBase> _createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<ViewModelBase> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigation()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
