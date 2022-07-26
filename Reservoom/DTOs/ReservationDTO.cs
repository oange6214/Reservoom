using System;
using System.ComponentModel.DataAnnotations;

namespace Reservoom.DTOs
{
    public class ReservationDTO
    {
        [Key]
        public Guid Id { get; set; }
        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }
        public string Username { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
