using Reservoom.Models;
using System.Threading.Tasks;

namespace Reservoom.Services.ReservationCreators
{
    public interface IReservationCreator
    {
        Task CreateReservation(Reservation reservation);
    }
}
