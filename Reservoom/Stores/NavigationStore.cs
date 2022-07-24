using Reservoom.ViewModels;
using System;

namespace Reservoom.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            { 
                _currentViewModel = value;
                OnCurrentViewModelChange();
            }
        }

        public event Action CurrentViewModelChanged;

        private void OnCurrentViewModelChange()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
