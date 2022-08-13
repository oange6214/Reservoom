using Reservoom.Stores;
using Reservoom.ViewModels;
using System;

namespace Reservoom.Services
{
    public class NavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<TViewModel> createViewModel)
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
