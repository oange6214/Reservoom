using Reservoom.Models;
using Reservoom.Stores;
using Reservoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace Reservoom.Commands
{
    public class LoadReservationsCommand : AsyncCommand
    {
        private readonly ReservationListingViewModel _viewModel;
        private readonly HotelStore _hotelStore;

        public LoadReservationsCommand(ReservationListingViewModel viewModel, HotelStore hotelStore)
        {
            _viewModel = viewModel;
            _hotelStore = hotelStore;
        } 

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                await _hotelStore.Load();
                
                _viewModel.UpdateReservations(_hotelStore.Reservations);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load reservation.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
