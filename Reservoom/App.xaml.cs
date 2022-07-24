using Reservoom.Models;
using Reservoom.Services;
using Reservoom.Stores;
using Reservoom.ViewModels;
using System;
using System.Windows;

namespace Reservoom
{
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _hotel = new Hotel("SingletonSean Suites");
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateReservationViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotel, new NavigationService(_navigationStore, CreateReservationViewModel));
        }

        private ReservationListingViewModel CreateReservationViewModel()
        {
            return new ReservationListingViewModel(_hotel, new NavigationService(_navigationStore, CreateMakeReservationViewModel));
        }
    }
}
 