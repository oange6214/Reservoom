using Microsoft.EntityFrameworkCore;
using Reservoom.DbContexts;
using Reservoom.Models;
using Reservoom.Services;
using Reservoom.Services.ReservationConflictValidators;
using Reservoom.Services.ReservationCreators;
using Reservoom.Services.ReservationProviders;
using Reservoom.Stores;
using Reservoom.ViewModels;
using System;
using System.Windows;

namespace Reservoom
{
    public partial class App : Application
    {
        private const string CONNECTION_STRING = "Data Source=reservoom.db";

        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            ReservoomDbContextFactory reservoomDbContextFactory = new ReservoomDbContextFactory(CONNECTION_STRING);
            IReservationProvider reservationProvider = new DatabaseReservationProvider(reservoomDbContextFactory);
            IReservationCreator reservationCreator = new DatabaseReservationCreator(reservoomDbContextFactory);
            IReservationConflictValidator reservationConflictValidator = new DatabaseReservationConflictValidator(reservoomDbContextFactory);

            ReservationBook reservationBook = new(reservationProvider, reservationCreator, reservationConflictValidator);
            _hotel = new Hotel("SingletonSean Suites", reservationBook);
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;
            using (ReservoomDbContext dbContext = new ReservoomDbContext(options))
            {
                dbContext.Database.Migrate();
            };

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
            return ReservationListingViewModel.LoadViewModel(_hotel, new NavigationService(_navigationStore, CreateMakeReservationViewModel));
        }
    }
}
 