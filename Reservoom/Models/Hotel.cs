using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        /// <summary>
        /// Get the reservations for a user.
        /// </summary>
        /// <param name="userName">The userName of the user.</param>
        /// <returns>The reservations for the user.</returns>
        public IEnumerable<Reservation> GetReservationsForUser(string userName)
        {
            return _reservationBook.GetReservationsForUser(userName);
        }

        /// <summary>
        /// Make a reservation
        /// </summary>
        /// <param name="reservation">The incoming reservation.</param>
        /// <exception cref="ReservationClict"
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
